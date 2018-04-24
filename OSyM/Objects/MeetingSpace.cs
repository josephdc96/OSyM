using OSyM.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Objects
{
    public class MeetingSpace : Room
    {
        public List<ReservationRequest> calendar = new List<ReservationRequest>();

        public List<ReservationRequest> GetCalendar()
        {
            return calendar;
        }
    }
}
