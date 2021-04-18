using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Ingredients_Click(object sender, RoutedEventArgs e)
        {
            IngredientsWindow window = new IngredientsWindow();
            window.Show();
        }

        private void Dishes_Click(object sender, RoutedEventArgs e)
        {
            DishesWindow window = new DishesWindow();
            window.Show();
        }

        private void DishesIngredients_Click(object sender, RoutedEventArgs e)
        {
            DishesIngredients window = new DishesIngredients();
            window.Show();
        }
    }
}
