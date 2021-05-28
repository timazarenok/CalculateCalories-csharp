using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for UserSettings.xaml
    public partial class UserSettings : Window
    {
        public UserSettings()
        {
            InitializeComponent();
            SetStatus();
        }
        private void SetStatus()
        {
            DataTable dt = SqlDB.Select($"select * from Statuses");
            List<string> statuses = new List<string>();
            foreach(DataRow dr in dt.Rows)
            {
                statuses.Add(dr["name"].ToString());
            }
            Status.ItemsSource = statuses;
        }

        private void Weight_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int status_id = SqlDB.GetId($"select * from Statuses where name='{Status.SelectedItem}'");
            if (SqlDB.Command($"update Users_Setting set status_id={status_id}, weight={Weight.Text}"))
            {
                MessageBox.Show("Параметры обновлены");
            }
        }
    }
}
