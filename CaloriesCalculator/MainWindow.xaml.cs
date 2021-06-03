using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CaloriesCalculator.Models;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace CaloriesCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Dish> items = new List<Dish>();
        public MainWindow()
        {
            InitializeComponent();
            GetIngredients();
            SetUserStats();
            GetUserSettings();
        }
        private void GetUserSettings()
        {
            DataTable dt = SqlDB.Select($"select * from Users_Setting join Statuses on Users_Setting.status_id = Statuses.id where user_id={SqlDB.UserID}");
            if(dt.Rows.Count != 0)
            {
                Status.Text = dt.Rows[0]["name"].ToString();
                Weight.Text = dt.Rows[0]["weight"].ToString();
            }
        }
        private void SetUserStats()
        {

            int calories = 0;
            int proteins = 0;
            int fats = 0;
            int carbohydrates = 0;
            int water = 0;
            SeriesCollection series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Калории",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(calories) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Белки",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(proteins) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Жиры",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(fats) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Углеводы",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(carbohydrates) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Вода",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(water) },
                    DataLabels = true
                }
            };
            Chart.Series = series;
        }
        public void GetIngredients()
        {
            DataTable data = SqlDB.Select($"select Dishes.id, Categories.[name] as category, Dishes.[name], proteins, fats, carbohydrates, calories from Dishes join Categories on Categories.id = id_category");
            items = new List<Dish>();
            foreach (DataRow dr in data.Rows)
            {
                items.Add(new Dish() { ID = Convert.ToInt32(dr["id"]), Name = dr["name"].ToString(), Category = dr["category"].ToString(), 
                    Calories = Convert.ToInt32(dr["calories"]), Proteins= Convert.ToInt32(dr["proteins"]), 
                    Fats = Convert.ToInt32(dr["fats"]), Carbohydrates = Convert.ToInt32(dr["carbohydrates"]) });
            }
            Ingredients.ItemsSource = items;
        }
        private void UpdateAllOnClick(object sender, RoutedEventArgs e)
        {
            DataTable dt = SqlDB.Select($"select * from Dayily_Stats where id_user={SqlDB.UserID} and [date]=(select convert(varchar(10),(select getdate()), 120))");
            if(dt.Rows.Count <= 0)
            {
                MessageBox.Show("Продукты не добавлены");
                return;
            }
            DataRow dr = dt.Rows[0];
            DailyStats ds = new DailyStats();
            ds = new DailyStats { Date = dr["date"].ToString(), Water = Convert.ToInt32(dr["water"]),
                Calories = Convert.ToInt32(dr["calories"]), Fats = Convert.ToInt32(dr["fats"]), 
                Proteins = Convert.ToInt32(dr["proteins"]), Carbohydrates = Convert.ToInt32(dr["carbohydrates"])
            };
            foreach (var series in Chart.Series)
            {
                foreach (var observable in series.Values.Cast<ObservableValue>())
                {
                    switch (series.Title)
                    {
                        case "Калории":
                            observable.Value = ds.Calories;
                            break;
                        case "Белки":
                            observable.Value = ds.Proteins;
                            break;
                        case "Жиры":
                            observable.Value = ds.Fats;
                            break;
                        case "Углеводы":
                            observable.Value = ds.Carbohydrates;
                            break;
                        case "Вода":
                            observable.Value = ds.Water;
                            break;
                    }
                }
            }
        }
        private void Items_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Ingredients.SelectedItem = sender;
        }

        private void AddInStatistics_Click(object sender, RoutedEventArgs e)
        {
            Dish dish = (Dish)Ingredients.SelectedItem;
            if (SqlDB.Command($"insert into Users_Dishes values ({SqlDB.UserID}, {dish.ID}, (SELECT getdate()))"));
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            if (SqlDB.Command("Update Dayily_Stats set water += 100;"));
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = Search.Text;
            Ingredients.ItemsSource = items.FindAll(item => item.Name.Contains(text));
        }

        private void PreviousDays_Click(object sender, RoutedEventArgs e)
        {
            PreviousDays window = new PreviousDays();
            window.Show();
        }
    }
}
