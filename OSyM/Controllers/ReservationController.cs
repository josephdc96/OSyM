using OSyM.Forms;
using OSyM.Objects;
using OSyM.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OSyM.Controllers
{
    public class ReservationController : Controller<ReservationRequest>
    {
        public ControllerTypes ControllerType => throw new NotImplementedException();
        public Account acct;

        public bool displayConfirmation(string message)
        {
            MessageBox.Show(message);
            return true;
        }

        public void executeRequest(ReservationRequest request)
        {
            App.building.Departments[0].MeetingRoom.GetCalendar().Add(request);
            displayConfirmation("Reservation Created");
        }

        public void submitReservationRequest(Account acct)
        {
            this.acct = acct;
            ReservationForm form = new ReservationForm(this);
            form.ShowDialog();
        }

        public List<ReservationRequest> displayReservations()
        {
            return App.building.Departments[0].MeetingRoom.GetCalendar();
        }

        public void send()
        {

        }
    }
}
