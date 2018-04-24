﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace OSyM.Objects
{
    public class Light
    {
        public double Brightness { get; set; }
        public bool Status { get; set; }
        public DateTime? OnTime { get; set; }
        public DateTime? OffTime { get; set; }
    }
}
