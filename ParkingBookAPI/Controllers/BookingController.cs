using DataModels.Classes;
using Microsoft.AspNetCore.Mvc;
using ParkingBookAPI.ServiceIntefaces;
using System;
using System.Threading.Tasks;

namespace ParkingBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService bookingService;

        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }
        [HttpPut]
        public async Task<IActionResult> CreateBokking(DateTime from, DateTime to)
        {
            return await bookingService.CreateBokking(from, to);
        }

        [HttpDelete]
        public async Task<IActionResult> CancelBokking(int bookingId)
        {
            return await bookingService.CancelBokking(bookingId);
        }

        [HttpPatch]
        public async Task<IActionResult> AmendBokking(CarParkBooking carParkBooking)
        {
            return await bookingService.AmendBokking(carParkBooking);
        }
    }
}
