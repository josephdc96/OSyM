﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Employee EmployeeObj { get; set; }
    }
}
