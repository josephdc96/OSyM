using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public List<Zone> Zones { get; set; }
        public InteriorLock Lock { get; set; }
    }
}
