using HotelBooking.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.API.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelBookingDB _dbContext;

        public HotelRepository(HotelBookingDB dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Hotel>> GetHotelsByCity()
        {
            List<Hotel> list = await Task.Run(() => _dbContext.Hotels.ToListAsync());

            return list;
            
        }
    }
}
