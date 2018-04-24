using OSyM.Controllers;
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
    /// Interaction logic for LogInForm.xaml
    /// </summary>
    public partial class LogInForm : Window
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AccountController controller = new AccountController();
            
            try
            {
                var result = controller.verifyAccount(new Account
                {
                    UserName = username.Text,
                    Password = password.Text
                });

                MainWindow dashboard = new MainWindow(result);
                dashboard.display();

                this.Close();
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Username not found");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Password incorrect");
            }
        }

        public void createForm()
        {
            this.ShowDialog();
        }
    }
}
