using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityHousing.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }
        [Required,MaxLength(250)]
        public string RoomName { get; set; }
        public decimal RoomPrice { get; set; }
        public int NumberOfBed { get; set; }
        public int AvailableOfBed { get; set; }
        public virtual List<Booking> Bookings { get; set; }

    }
}
