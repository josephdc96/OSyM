using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public interface IDoorLock
    {
        bool Status { get; set; }
    }

    public class ExteriorLock : IDoorLock
    {
        public bool Status { get; set; }
    }

    public class InteriorLock : IDoorLock
    {
        public bool Status { get; set; }
    }
}
