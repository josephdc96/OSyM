using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Controllers
{
    public interface Controller
    {
        ControllerTypes ControllerType { get; }

        void DisplayConfirmation(string message);
    }

    public enum ControllerTypes
    {
        Account, Alert, Message, Reservation, Lock, Light, Temperature
    }
}
