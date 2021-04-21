using CaloriesCalculator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
using System.Windows.Shapes;

namespace CaloriesCalculator
{
    /// <summary>
    /// Логика взаимодействия для PreviousDays.xaml
    /// </summary>
    public partial class PreviousDays : Window
    {
        public PreviousDays()
        {
            InitializeComponent();
            SetStatistic();
        }
        public void SetStatistic()
        {
            DataTable dt = SqlDB.Select($"select * from Dayily_Stats where id_user={SqlDB.UserID}");
            List<DailyStats> stats = new List<DailyStats>();
            foreach(DataRow dr in dt.Rows)
            {
                stats.Add(new DailyStats { ID = Convert.ToInt32(dr["id"]), Date = dr["date"].ToString(), Water = Convert.ToInt32(dr["water"]), 
                    Proteins = Convert.ToInt32(dr["proteins"]), Fats = Convert.ToInt32(dr["fats"]), 
                    Carbohydrates = Convert.ToInt32(dr["carbohydrates"]), Calories = Convert.ToInt32(dr["calories"])
                });
            }
            Statistic.ItemsSource = stats;
        }

        private void Statistic_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Statistic.SelectedItem = sender;
            DailyStats daily = (DailyStats)Statistic.SelectedItem;
            DateTime result = DateTime.ParseExact(daily.Date.Substring(0,10), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string date = result.ToString("yyyy-MM-dd");
            DataTable dt = SqlDB.Select($"select Dishes.[name], proteins, fats, carbohydrates, calories from Users_Dishes join Dishes on Dishes.id = id_dish where id_user={SqlDB.UserID} and [date]='{date}'");
            List<Dish> dishes = new List<Dish>();
            foreach (DataRow dr in dt.Rows)
            {
                dishes.Add(new Dish
                {
                    Name = dr["name"].ToString(),
                    Proteins = Convert.ToInt32(dr["proteins"]),
                    Fats = Convert.ToInt32(dr["fats"]),
                    Carbohydrates = Convert.ToInt32(dr["carbohydrates"]),
                    Calories = Convert.ToInt32(dr["calories"])
                });
            }
            Table.ItemsSource = dishes;
        }
    }
}
