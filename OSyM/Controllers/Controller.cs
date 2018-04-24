using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Controllers
{
    public interface Controller<T> where T : Requests.Request
    {
        ControllerTypes ControllerType { get; }

        bool displayConfirmation(string message);
        void executeRequest(T request);
    }

    public enum ControllerTypes
    {
        Account, Alert, Message, Reservation, Lock, Light, Temperature
    }
}
