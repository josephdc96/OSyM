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
using System.Windows.Navigation;
using System.Windows.Shapes;
using OSyM.Objects;
using OSyM.Forms;
using OSyM.Controllers;
using OSyM.Requests;
using System.Windows.Threading;

namespace OSyM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Zone zone;
        private Account acct;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow(Account account)
        {
            this.acct = account;
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Start();
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            updateValues();
        }

        public void display()
        {
            Show();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            int roomNum = Int32.Parse(acct.EmployeeObj.ZoneCode.Substring(0, 3));
            Room room = App.building.Departments[0].Rooms.Where(x => x.RoomNumber == roomNum).First();
            zone = room.Zones.Where(x => x.ZoneCode == acct.EmployeeObj.ZoneCode).First();

            updateValues();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AlertController alert = new AlertController();
            alert.submitAlert(new Alarm());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LightController light = new LightController(zone.MyLight);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TemperatureController temp = new TemperatureController(zone.MyVent);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageController controller = new MessageController();
            controller.submitMessage(new Requests.MessageRequest
            {
                AccountID = acct.EmployeeObj.IDNumber,
                Content = message.Text,
                SendTime = DateTime.Now
            });
        }

        private void updateValues()
        {
            lightVal.Content = (zone.MyLight.Status ? "On: " + zone.MyLight.Brightness + "%." : "Off");
            tempVal.Content = zone.MyVent.Temperature + "°F";

            try
            {
                messages.Items.Clear();
                foreach (MessageRequest request in App.building.Departments[0].Messages.Messages)
                {
                    messages.Items.Add(request.Content);
                }
            }
            catch
            {
                
            }

            reservations.Items.Clear();
            foreach (ReservationRequest request in new ReservationController().displayReservations())
            {
                reservations.Items.Add(new ListViewItem
                {
                    Content = request.startTime.ToLocalTime() + "-" + request.endTime.ToLocalTime(),
                    Tag = request
                });
            }

            if (acct.EmployeeObj.GetType() == typeof(BuildingManager))
            {
                exterior.Items.Clear();
                int i = 0;
                foreach (ExteriorLock lck in App.building.Locks)
                {
                    exterior.Items.Add(new ListViewItem
                    {
                        Content = "Lock " + i + ": " + (lck.Status ? "Engaged" : "Disengaged"),
                        Tag = lck
                    });

                    i++;
                }
            }

            interior.Items.Clear();
            interior.Items.Add(new ListViewItem
            {
                Content = "Lock 1: " + (App.building.Departments[0].Rooms[0].Lock.Status ? "Engaged" : "Disengaged"),
                Tag = App.building.Departments[0].Rooms[0].Lock
            });
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ReservationController controller = new ReservationController();
            controller.submitReservationRequest(acct);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (exterior.SelectedItem != null)
            {
                ((ExteriorLock)(((ListViewItem)exterior.SelectedItem).Tag)).Status = !((ExteriorLock)(((ListViewItem)exterior.SelectedItem).Tag)).Status;
            }
            else if (interior.SelectedItem != null)
            {
                ((InteriorLock)(((ListViewItem)interior.SelectedItem).Tag)).Status = !((InteriorLock)(((ListViewItem)interior.SelectedItem).Tag)).Status;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }
    }
}
