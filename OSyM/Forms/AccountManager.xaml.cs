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
    /// Interaction logic for AccountManager.xaml
    /// </summary>
    public partial class AccountManager : Window
    {
        Account acct;
        public AccountManager(Account acct)
        {
            this.acct = acct;
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            name.Content = "Name: " + acct.EmployeeObj.FirstName + ' ' + acct.EmployeeObj.LastName;
            username.Content = "Username: " + acct.UserName;
            zone.Content = "Zone: " + acct.EmployeeObj.ZoneCode;
        }
    }
}
