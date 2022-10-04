using HotelBooking.API.Models;

namespace HotelBooking.API.Repository
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetHotelsByCity(); 
    }
}
