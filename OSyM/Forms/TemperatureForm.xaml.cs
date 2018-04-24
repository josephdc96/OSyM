using OSyM.Controllers;
using OSyM.Requests;
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
    /// Interaction logic for TemperatureForm.xaml
    /// </summary>
    public partial class TemperatureForm : Window
    {
        TemperatureController controller;

        public TemperatureForm(TemperatureController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            controller.executeRequest(new TemperatureRequest
            {
                TemperatureValue = temperature.Value
            });
            this.Close();
        }
    }
}
