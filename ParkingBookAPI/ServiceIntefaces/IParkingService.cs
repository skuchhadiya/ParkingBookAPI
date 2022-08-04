using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ParkingBookAPI.ServiceIntefaces
{
    public interface IParkingService
    {
        Task<IActionResult> GetAvailableSpace(DateTime from, DateTime to);
        Task<IActionResult> GetPrices(DateTime date);
    }
}
