using DataModels.Classes;
using Microsoft.AspNetCore.Mvc;
using ParkingBookAPI.ServiceIntefaces;
using System;
using System.Threading.Tasks;

namespace ParkingBookAPI.Services
{
    public class BookingService : IBookingService
    {
        public Task<IActionResult> AmendBokking(CarParkBooking carParkBooking)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> CancelBokking(int bookingId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> CreateBokking(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
