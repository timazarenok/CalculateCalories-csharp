using CaloriesCalculator.Models;
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
    /// Логика взаимодействия для CategoriesWindow.xaml
    /// </summary>
    public partial class CategoriesWindow : Window
    {
        public CategoriesWindow()
        {
            InitializeComponent();
            SetIngredients();
        }
        public void SetIngredients()
        {
            List<Category> categories = new List<Category>();
            DataTable dt = SqlDB.Select("select * from Categories");
            foreach (DataRow dr in dt.Rows)
            {
                categories.Add(new Category { Name = dr["name"].ToString() });
            }
            Table.ItemsSource = categories;
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (SqlDB.Command($"insert into Categories values ('{Content.Text}')"))
            {
                SetIngredients();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (SqlDB.Command($"delete from Categories where [name]='{Content.Text}'"))
            {
                SetIngredients();
            }
        }
    }
}
