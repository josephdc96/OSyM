using OSyM.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Controllers
{
    public class MessageController : Controller<MessageRequest>
    {
        public ControllerTypes ControllerType => throw new NotImplementedException();

        public bool displayConfirmation(string message)
        {
            throw new NotImplementedException();
        }

        public void executeRequest(MessageRequest request)
        {
            throw new NotImplementedException();
        }

        public void submitMessage(MessageRequest request)
        {
            if (App.building.Departments[0].Messages == null) App.building.Departments[0].Messages = new Objects.MessageBoard();

            App.building.Departments[0].Messages.sendMessage(request);
        }
    }
}
