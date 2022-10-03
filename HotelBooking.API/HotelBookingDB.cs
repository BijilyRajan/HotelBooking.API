using HotelBooking.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.API
{
    public class HotelBookingDB : DbContext
    {
        public HotelBookingDB(DbContextOptions<HotelBookingDB> options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
