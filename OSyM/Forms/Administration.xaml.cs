using OSyM.Objects;
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

namespace OSyM.Forms
{
    /// <summary>
    /// Interaction logic for Administration.xaml
    /// </summary>
    public partial class Administration : Window
    {
        Account currentUser;

        public Administration(Account currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            foreach (Account acct in App.user.Values)
            {
                accounts.Items.Add(new ListViewItem
                {
                    Content = acct.UserName + " - " + acct.EmployeeObj.FirstName + " " + acct.EmployeeObj.LastName,
                    Tag = acct
                });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (accounts.SelectedItem.Equals(currentUser))
            {
                MessageBox.Show("You cannot delete your own account");
                return;
            }

            try
            {
                App.user.Remove(((Account)accounts.SelectedItem).UserName);
            }
            catch
            {

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Vent vent = null;
            foreach (Zone zone in App.building.Departments[0].Rooms[0].Zones)
            {
                if (zone.ZoneCode == ((Account)accounts.SelectedItem).EmployeeObj.ZoneCode)
                {
                    vent = zone.MyVent;
                    break;
                }
            }

            if (vent == null) return;

            TemperatureForm form = new TemperatureForm(new Controllers.TemperatureController(vent));
            form.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ChangeAccessForm form = new ChangeAccessForm(((Account)accounts.SelectedItem));
            form.ShowDialog();
        }
    }
}
