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
using System.Windows.Shapes;

namespace CaloriesCalculator
{
    /// <summary>
    /// Логика взаимодействия для DishesWindow.xaml
    /// </summary>
    public partial class DishesWindow : Window
    {
        public DishesWindow()
        {
            InitializeComponent();
            Categories.ItemsSource = SqlDB.GetDataOneAttribute("select [name] from Categories", "name");
            SetDishes();
        }

        public void SetDishes()
        {
            List<Dish> dishes = new List<Dish>();
            DataTable dt = SqlDB.Select($"select Dishes.id, Categories.[name] as category, Dishes.[name], proteins, fats, carbohydrates, calories from Dishes join Categories on Categories.id = id_category");
            foreach (DataRow dr in dt.Rows)
            {
                dishes.Add(new Dish()
                {
                    Name = dr["name"].ToString(),
                    Category = dr["category"].ToString(),
                    Calories = Convert.ToInt32(dr["calories"]),
                    Proteins = Convert.ToInt32(dr["proteins"]),
                    Fats = Convert.ToInt32(dr["fats"]),
                    Carbohydrates = Convert.ToInt32(dr["carbohydrates"])
                });
            }
            Table.ItemsSource = dishes;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            string category = Categories.SelectedItem.ToString();
            int category_id = SqlDB.GetId($"select id from Categories where [name]='{category}'");
            if (SqlDB.Command($"insert into Dishes values ({category_id}, '{Content.Text}', {0}, {0}, {0}, {0})"))
            {
                SetDishes();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (SqlDB.Command($"delete from Dishes where [name] = '{Content.Text}'"))
            {
                SetDishes();
            }
        }
    }
}
