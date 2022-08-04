using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Classes
{
    public class WinterCarParking : CarParking
    {
        int CarParking.TotalSpace { get => 10; }
        double CarParking.Price { get => 10.50; }
    }
}
