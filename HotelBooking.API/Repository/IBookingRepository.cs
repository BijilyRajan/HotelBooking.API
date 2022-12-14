using HotelBooking.API.Models;

namespace HotelBooking.API.Repository
{
    public interface IBookingRepository
    {
        Task<List<Room>> GetRooms();
    }
}
