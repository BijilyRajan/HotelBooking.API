using HotelBooking.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.API.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly HotelBookingDB _dbContext;

        public BookingRepository(HotelBookingDB dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Room>> GetRooms()
        {
            List<Room> list = await Task.Run(() => _dbContext.Rooms.ToListAsync());

            return list;
        }
    }
}
