using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public class Zone
    {
        public string ZoneCode { get; set; }
        public Light MyLight { get; set; }
        public Vent MyVent { get; set; }
    }
}
