using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityHousing.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        //[ForeignKey("Students")]
        //public int StudentId { get; set; }
        //public virtual Student Students { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Payment Payment { get; set; }
        public string? Description { get; set; }
        public typeStatus requestStatus { get; set; }



    }
    public enum typeStatus
    {
        Accept=1,
        Reject,
        notSpecify
    }
}
