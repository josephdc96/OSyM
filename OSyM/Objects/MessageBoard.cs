using OSyM.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public class MessageBoard
    {
        public List<MessageRequest> Messages = new List<MessageRequest>();

        public void sendMessage(MessageRequest message)
        {
            Messages.Add(message);
        }
    }
}
