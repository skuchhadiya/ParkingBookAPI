using DataModels.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ParkingBookAPI.ServiceIntefaces
{
    public interface IBookingService
    {
        Task<IActionResult> CreateBokking(DateTime from, DateTime to);

        Task<IActionResult> CancelBokking(int bookingId);

        Task<IActionResult> AmendBokking(CarParkBooking carParkBooking);
        
    }
}
