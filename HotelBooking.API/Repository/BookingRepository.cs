namespace HotelBooking.API.Repository
{
    public class BookingRepository : IBookingRepository
    {
        public List<Room> GetAvailableRooms()
        {
            return new List<Room>
            {

                new Room
                {
                    HotelId = 1000, RoomTypeId = 1, RoomType = "Double Delux", RoomName = "Valley View", AvailabileRooms = 4, Rate = 5000, ImageName = "1000_DD_VV"
                },
        
                new Room{
                    HotelId = 1000, RoomTypeId = 2, RoomType = "Supreme", RoomName = "Mountain View", AvailabileRooms = 2, Rate = 7000, ImageName = "1000_SP_MV"
                },
                
                new Room
                {
                    HotelId = 1000, RoomTypeId = 3, RoomType = "Cottage", RoomName = "Pool View", AvailabileRooms = 6, Rate = 10000, ImageName = "1000_CT_PV"
                },

                new Room{
                    HotelId = 1000, RoomTypeId = 4, RoomType = "Tree House", RoomName = "Landscape View", AvailabileRooms = 8, Rate = 12000, ImageName = "1000_TH_LV"
                },

                new Room{
                    HotelId = 1000, RoomTypeId = 5, RoomType = "Beach House", RoomName = "Sea View", AvailabileRooms = 4, Rate = 2000, ImageName = "1000_BH_SV"
                }
};
        }
    }
}
