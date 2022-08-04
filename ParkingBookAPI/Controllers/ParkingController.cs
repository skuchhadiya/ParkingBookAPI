using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingBookAPI.ServiceIntefaces;
using System;
using System.Threading.Tasks;

namespace ParkingBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService parkingService;

        public ParkingController(IParkingService parkingService)
        {
            this.parkingService = parkingService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAvailableSpace(DateTime from, DateTime to ) {
            return await parkingService.GetAvailableSpace(from, to);
        }

        [HttpGet]
        public async Task<IActionResult> GetAvailablePrices(DateTime date)
        {
            return await parkingService.GetPrices(date);
        }


    }
}
