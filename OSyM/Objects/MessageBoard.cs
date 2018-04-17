using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public static class MessageBoard
    {
        public static List<Message> Messages { get; set; }
    }

    public class Message
    {
        public Account CreatedBy { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        
    }
}
