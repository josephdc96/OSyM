using OSyM.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSyM.Requests
{
    public class ReservationRequest : Request
    {
        public int roomNumber;
        public DateTime startTime;
        public DateTime endTime;
        public DateTime date;
        public Account acct;
    }
}
