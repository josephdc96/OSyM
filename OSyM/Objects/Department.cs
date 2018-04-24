using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public class Department
    {
        public int DepartmentNumber { get; set; }
        public Room[] Rooms { get; set; }
        public MeetingSpace MeetingRoom { get; set; }
        public MessageBoard Messages { get; set; }
    }
}
