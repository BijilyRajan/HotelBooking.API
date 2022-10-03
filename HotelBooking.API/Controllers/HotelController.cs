using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly HotelBookingDB _dbContext;

        public HotelController(HotelBookingDB dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetHotelsByCity")]
        public async Task<IActionResult> GetHotelsByCity(string City)
        {
            var hotels = await _dbContext.Hotels.ToListAsync();

            var hotelsbycity = hotels.AsEnumerable()
                .Where(q => City.Contains(q.City))
                .ToArray();

            return Ok(hotelsbycity);
        }
    }
}
