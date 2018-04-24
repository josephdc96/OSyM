using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Requests
{
    public class MessageRequest : Request
    {
        public string Content { get; set; }
        public DateTime SendTime { get; set; }
        public int AccountID { get; set; }
    }
}
