using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OSyM.Forms;
using OSyM.Objects;

namespace OSyM.Controllers
{
    public class AlertController : Controller
    {
        public ControllerTypes ControllerType => ControllerTypes.Alert;

        public Alarm alarm { get; set; }

        public string AlertType;

        public AlertController(Alarm alarm)
        {
            this.alarm = alarm;
        }

        public void submitAlert()
        {
            AlertForm form = new AlertForm(this);
            if (form.ShowDialog() == true) ;
        }

        public void DisplayConfirmation(string message)
        {
            var result = MessageBox.Show(message, "Alarm Message");
        }
    }
}
