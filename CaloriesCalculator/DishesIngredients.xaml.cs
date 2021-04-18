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
    /// Логика взаимодействия для DishesIngredients.xaml
    /// </summary>
    public partial class DishesIngredients : Window
    {
        public DishesIngredients()
        {
            InitializeComponent();
            SetDishes();
            Ingredients.ItemsSource = SqlDB.GetDataOneAttribute("select [name] from Ingredients", "name");
            Dishes.ItemsSource = SqlDB.GetDataOneAttribute("select [name] from Dishes", "name");
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
            string ingredient = Ingredients.SelectedItem.ToString();
            string dish = Dishes.SelectedItem.ToString();
            int ingredient_id = SqlDB.GetId($"select id from Ingredients where [name]='{ingredient}'");
            int dish_id = SqlDB.GetId($"select id from Dishes where [name]='{dish}'");
            if (SqlDB.Command($"insert into Dishes_Ingredients values ({ingredient_id}, {dish_id})"))
            {
                SetDishes();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string ingredient = Ingredients.SelectedItem.ToString();
            string dish = Dishes.SelectedItem.ToString();
            int ingredient_id = SqlDB.GetId($"select id from Ingredients where [name]='{ingredient}'");
            int dish_id = SqlDB.GetId($"select id from Dishes where [name]='{dish}'");
            if (SqlDB.Command($"delete from Dishes_Ingredients where id_ingredient = {ingredient_id} and id_dish = {dish_id}"))
            {
                SetDishes();
            }
        }
    }
}
