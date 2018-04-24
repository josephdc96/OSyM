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
    public class TemperatureController : Controller<TemperatureRequest>
    {
        public ControllerTypes ControllerType => throw new NotImplementedException();
        public Vent vent;

        public TemperatureController(Vent vent)
        {
            this.vent = vent;
            Window ventWindow = new TemperatureForm(this);
            ventWindow.ShowDialog();
        }

        public void submitTemperatureRequest(Vent vent)
        {
            this.vent = vent;
            Window ventWindow = new TemperatureForm(this);
            ventWindow.ShowDialog();
        }

        public bool displayConfirmation(string message)
        {
            var result = MessageBox.Show(message, "Temp Request Message", MessageBoxButton.OKCancel);
            return result == MessageBoxResult.OK;
        }

        public void executeRequest(TemperatureRequest request)
        {
            if (request.TemperatureValue < 60 || request.TemperatureValue > 80)
            {
                if (displayConfirmation("Temperature must be between 60 and 80 degrees."))
                {
                    Window ventWindow = new TemperatureForm(this);
                    ventWindow.ShowDialog();
                }
                return;
            }

            vent.Temperature = request.TemperatureValue;
        }
    }
}
