using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public class Building
    {
        public Department[] Departments { get; set; }
        public ExteriorLock[] Locks { get; set; }
    }
}
