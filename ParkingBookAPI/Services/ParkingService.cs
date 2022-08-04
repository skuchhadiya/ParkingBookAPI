using Microsoft.AspNetCore.Mvc;
using ParkingBookAPI.ServiceIntefaces;
using System;
using System.Threading.Tasks;

namespace ParkingBookAPI.Services
{
    public class ParkingService : IParkingService
    {
        public Task<IActionResult> GetAvailableSpace(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetPrices(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
