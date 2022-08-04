using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Classes
{
    public class CarParkingItem
    {
        public int TotalSpace { get; set; }
        public int AvailableSpace { get; set; }

        public double Price { get; }
        private CarParking carParking { get; set; }
        public CarParkingItem(DateTime date) {

            // TO crete type of car park and then load the price for summer or winter
            var info = TimeZoneInfo.FindSystemTimeZoneById("Greenwich Standard Time");
            bool isDaylightSaving = info.IsDaylightSavingTime(date);
            if(isDaylightSaving == true)
            {
                carParking = new SummerCarParking();
                this.TotalSpace = carParking.TotalSpace;
                this.Price = carParking.Price;
            }
            else
            {
                carParking = new WinterCarParking();
                this.TotalSpace = carParking.TotalSpace;
                this.Price = carParking.Price;
            }
        }
    }
}
