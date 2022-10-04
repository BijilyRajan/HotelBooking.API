using HotelBooking.API.Models;
using HotelBooking.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        //private readonly DbContext _dbContext;
        //Time being I am using in memory data beacuse I need to submit the project on Oct-5, 2022

        private readonly IBookingRepository _dbRepository;

        public BookingController(IBookingRepository bookingRepository)
        {
            _dbRepository = bookingRepository;
        }

        [HttpGet("GetRooms")]
        public async Task<IActionResult> GetRooms(int hotelId)
        {
            var hotels = await _dbRepository.GetRooms();

            var hotelsbycity = hotels.AsEnumerable()
                .Where(q => hotelId.Equals(q.HotelId))
                .ToArray();

            return Ok(hotelsbycity);
        }


    }
}
