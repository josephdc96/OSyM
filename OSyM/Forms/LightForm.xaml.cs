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
    /// Interaction logic for LightForm.xaml
    /// </summary>
    public partial class LightForm : Window
    {
        public LightController controller;

        public LightForm(LightController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void lightOn_Checked(object sender, RoutedEventArgs e)
        {
            brightness.IsEnabled = true;
        }

        private void lightOn_Unchecked(object sender, RoutedEventArgs e)
        {
            brightness.IsEnabled = false;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            lightOn.IsChecked = controller.light.Status;
            brightness.Value = controller.light.Brightness;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? onTime;
            DateTime? offTime;

            if (OnTime.IsChecked != true)
            {
                onTime = null;
            }
            else
            {
                DateTime temp;
                DateTime.TryParse(OnTimeBox.Text, out temp);
                onTime = temp;
            }

            if (OffTime.IsChecked != true)
            {
                offTime = null;
            }
            else
            {
                DateTime temp;
                DateTime.TryParse(OffTimeBox.Text, out temp);
                offTime = temp;
            }

            controller.executeRequest(new Requests.LightRequest
            {
                BrightnessValue = lightOn.IsChecked == true ? brightness.Value : 0,
                OnTime = onTime,
                OffTime = offTime
            });
            this.Close();
        }

        private void OnTime_Checked(object sender, RoutedEventArgs e)
        {
            try { OnTimeBox.IsEnabled = true; } catch { }
        }

        private void OffTime_Checked(object sender, RoutedEventArgs e)
        {
            try { OffTimeBox.IsEnabled = true; } catch { }
        }

        private void OnTime_Unchecked(object sender, RoutedEventArgs e)
        {
            OnTimeBox.IsEnabled = false;
        }

        private void OffTime_Unchecked(object sender, RoutedEventArgs e)
        {
            OffTime.IsEnabled = false;
        }
    }
}
