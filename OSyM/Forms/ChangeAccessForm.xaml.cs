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
    /// Interaction logic for ChangeAccessForm.xaml
    /// </summary>
    public partial class ChangeAccessForm : Window
    {
        Account acct;

        public ChangeAccessForm(Account acct)
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            if (acct.EmployeeObj.GetType() == typeof(Employee))
            {
                access.SelectedIndex = 0;
            }
            else if (acct.EmployeeObj.GetType() == typeof(DepartmentManager))
            {
                access.SelectedIndex = 1;
            }
            else if (acct.EmployeeObj.GetType() == typeof(BuildingManager))
            {
                access.SelectedIndex = 2;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (access.SelectedIndex)
            {
                case 0:
                    acct.EmployeeObj = Employee.ConvertTo<BasicEmployee>(acct.EmployeeObj);
                    break;
                case 1:
                    acct.EmployeeObj = Employee.ConvertTo<DepartmentManager>(acct.EmployeeObj);
                    break;
                case 2:
                    acct.EmployeeObj = Employee.ConvertTo<BuildingManager>(acct.EmployeeObj);
                    break;
                default:
                    MessageBox.Show("Unknown error");
                    return;
            }
            Close();
        }
    }
}
