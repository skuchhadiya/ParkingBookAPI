using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public interface CarParking
    { 
        int TotalSpace { get; }
        double Price { get; }
    }
}
