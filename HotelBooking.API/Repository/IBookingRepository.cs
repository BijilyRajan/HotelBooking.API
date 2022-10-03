namespace HotelBooking.API.Repository
{
    public interface IBookingRepository
    {
        List<Room> GetAvailableRooms();
    }
}
