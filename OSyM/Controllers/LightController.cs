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
    public class LightController : Controller<LightRequest>
    {
        public ControllerTypes ControllerType => throw new NotImplementedException();
        public Light light;

        public LightController(Light light)
        {
            this.light = light;
            LightForm form = new LightForm(this);
            form.ShowDialog();
        }

        public void submitLightRequest(Light light)
        {
            this.light = light;
            LightForm form = new LightForm(this);
            form.ShowDialog();
        }

        public bool displayConfirmation(string message)
        {
            var result = MessageBox.Show(message, "Result", MessageBoxButton.OKCancel);
            return result == MessageBoxResult.OK;
        }

        public void executeRequest(LightRequest request)
        {
            if (request.BrightnessValue < 0)
            {
                if (displayConfirmation("Error: Brightness must be a positive integer."))
                {
                    LightForm form = new LightForm(this);
                    form.ShowDialog();
                }
                return;
            }

            if (request.BrightnessValue == 0)
            {
                light.Status = false;
                light.OnTime = request.OnTime;
                light.OffTime = request.OffTime;
                light.Brightness = 0;
            }
            else
            {
                light.Status = true;
                light.OnTime = request.OnTime;
                light.OffTime = request.OffTime;
                light.Brightness = request.BrightnessValue;
            }

            displayConfirmation("Light successfuly changed.");
        }
    }
}
