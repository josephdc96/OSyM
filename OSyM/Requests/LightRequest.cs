using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Requests
{
    public class LightRequest : Request
    {
        public double BrightnessValue { get; set; }
        public DateTime? OnTime { get; set; }
        public DateTime? OffTime { get; set; }
    }
}
