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

        private readonly IBookingRepository _bookingRepository;

        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet("GetRooms")]
        public List<Room> GetRooms(string fromDate, string toDate)
        {
            return _bookingRepository.GetAvailableRooms();
        }


    }
}
