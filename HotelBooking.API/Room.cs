namespace HotelBooking.API
{
    public class Room
    {
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public string? RoomType { get; set; }
        public string? RoomName { get; set; }
        public int AvailabileRooms { get; set; }
        public decimal Rate { get; set; }
        public string? ImageName { get; set; }
    }
}
