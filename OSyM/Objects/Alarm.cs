using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OSyM.Objects
{
    public class Alarm
    {
        public bool Status { get; set; }

        public void soundAlarm(string content)
        {
            Status = true;
            MessageBox.Show(content, "ALERT!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
