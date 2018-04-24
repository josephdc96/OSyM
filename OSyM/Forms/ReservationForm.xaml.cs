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
    /// Interaction logic for ReservationForm.xaml
    /// </summary>
    public partial class ReservationForm : Window
    {
        ReservationController controller;

        public ReservationForm(ReservationController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime start = DateTime.Parse(startText.Text);
                DateTime end = DateTime.Parse(startText.Text);

                ReservationRequest req = new ReservationRequest
                {
                    date = (DateTime)date.SelectedDate,
                    startTime = start,
                    endTime = end,
                    roomNumber = 2,
                    acct = controller.acct
                };

                controller.executeRequest(req);
            }
            catch (Exception)
            {
                MessageBox.Show("Times must be in hh:mm AM/PM format.");
            }
        }
    }
}
