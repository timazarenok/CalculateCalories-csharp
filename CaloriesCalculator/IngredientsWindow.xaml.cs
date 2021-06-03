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
                    Weight = Convert.ToDouble(dr["weight"]),
                    Calories = Convert.ToDouble(dr["calories"]),
                    Proteins = Convert.ToDouble(dr["proteins"]),
                    Fats = Convert.ToDouble(dr["fats"]),
                    Carbohydrates = Convert.ToDouble(dr["carbohydrates"])
                });
            }
            Table.ItemsSource = ingredients;
        }

        public double CaloriesCalculate(double p, double f, double c)
        {
            return p * 4 + f * 9 + c * 4;

        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            double weight = Convert.ToDouble(Weight.Text);
            double proteins = Convert.ToDouble(Proteins.Text);
            double fats = Convert.ToDouble(Fats.Text);
            double carbohydrates = Convert.ToDouble(Carbohydrates.Text);
            if(SqlDB.Command($"insert into Ingredients values ('{Content.Text}', {weight}, {CaloriesCalculate(proteins, fats, carbohydrates)}, {proteins}, {fats}, {carbohydrates})"))
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
