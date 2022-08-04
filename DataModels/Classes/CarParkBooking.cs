using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Classes
{
    public class CarParkBooking
    {
        int BookingId { get; set; }

        DateTime From { get; set; }
        DateTime To { get; set; }
        double Total { get; set; }

    }
}
