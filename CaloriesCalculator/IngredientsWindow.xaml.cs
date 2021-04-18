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
    /// Логика взаимодействия для IngredientsWindow.xaml
    /// </summary>
    public partial class IngredientsWindow : Window
    {
        public IngredientsWindow()
        {
            InitializeComponent();
            SetIngredients();
        }

        public void SetIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            DataTable dt = SqlDB.Select("select * from Ingredients");
            foreach (DataRow dr in dt.Rows)
            {
                ingredients.Add(new Ingredient()
                {
                    Name = dr["name"].ToString(),
                    Weight = Convert.ToInt32(dr["weight"]),
                    Calories = Convert.ToInt32(dr["calories"]),
                    Proteins = Convert.ToInt32(dr["proteins"]),
                    Fats = Convert.ToInt32(dr["fats"]),
                    Carbohydrates = Convert.ToInt32(dr["carbohydrates"])
                });
            }
            Table.ItemsSource = ingredients;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            int weight = Convert.ToInt32(Weight.Text);
            int calories = Convert.ToInt32(Calories.Text);
            int proteins = Convert.ToInt32(Proteins.Text);
            int fats = Convert.ToInt32(Fats.Text);
            int carbohydrates = Convert.ToInt32(Carbohydrates.Text);
            if(SqlDB.Command($"insert into Ingredients values ('{Content.Text}', {weight}, {calories}, {proteins}, {fats}, {carbohydrates})"))
            {
               SetIngredients();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(SqlDB.Command($"delete from Ingredients where [name] = '{Content.Text}'"))
            {
                SetIngredients();
            }
        }
    }
}
