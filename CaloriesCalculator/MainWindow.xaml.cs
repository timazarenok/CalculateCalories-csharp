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

namespace CaloriesCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetIngredients();
        }

        public void GetIngredients()
        {
            DataTable data = SqlDB.Select($"select * from Ingredients");
            List<Ingredient> items = new List<Ingredient>();
            foreach (DataRow dr in data.Rows)
            {
                items.Add(new Ingredient() { Name = dr["name"].ToString(), Weight = Convert.ToInt32(dr["weight"]), 
                    Calories = Convert.ToInt32(dr["calories"]), Proteins= Convert.ToInt32(dr["proteins"]), 
                    Fats = Convert.ToInt32(dr["fats"]), Carbohydrates = Convert.ToInt32(dr["carbohydrates"]) });
            }
            Ingredients.ItemsSource = items;
        }
        private void Items_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Ingredients.SelectedItem = sender;
        }
    }
}
