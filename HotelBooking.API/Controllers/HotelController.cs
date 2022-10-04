using HotelBooking.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _dbRepository;

        public HotelController(IHotelRepository dbContext)
        {
            _dbRepository = dbContext;
        }

        [HttpGet]
        [Route("GetHotelsByCity")]
        public async Task<IActionResult> GetHotelsByCity(string City)
        {
            var hotels = await _dbRepository.GetHotelsByCity();

            var hotelsbycity = hotels.AsEnumerable()
                .Where(q => City.Contains(q.City))
                .ToArray();

            return Ok(hotelsbycity);
        }
    }
}
