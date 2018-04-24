using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OSyM.Forms;
using OSyM.Objects;
using OSyM.Requests;

namespace OSyM.Controllers
{
    public class AlertController : Controller<AlertRequest>
    {
        public ControllerTypes ControllerType => ControllerTypes.Alert;

        public Alarm alarm { get; set; }

        public string AlertType;

        public void submitAlert(Alarm alarm)
        {
            this.alarm = alarm;
            AlertForm form = new AlertForm(this);
            form.ShowDialog();
        }

        public bool displayConfirmation(string message)
        {
            var result = MessageBox.Show(message, "Alarm Message");
            return true;
        }

        public void executeRequest(AlertRequest request)
        {
            alarm.soundAlarm(request.AlertType);
            displayConfirmation("Alert Created");
        }
    }
}
