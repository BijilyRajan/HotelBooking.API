using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.API.Models
{

	public class Hotel
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[System.Text.Json.Serialization.JsonIgnore]
		public int HotelId { get; set; }
		public string? HotelName { get; set; }
		public string? City { get; set; }
		public string? Country  { get; set; }
		public int StarRating  { get; set; }
		public decimal AveragePrice { get; set; }
		public string? ImageName  { get; set; }

	}
}
