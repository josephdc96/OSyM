using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IDNumber { get; set; }
        public string ZoneCode { get; set; }
    }

    public class BasicEmployee : Employee { }

    public abstract class Administrator : Employee { }

    public class DepartmentManager : Administrator { }

    public class BuildingManager : Administrator { }
}
