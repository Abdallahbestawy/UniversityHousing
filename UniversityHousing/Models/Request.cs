//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace UniversityHousing.Models
//{
//    public class Request
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        public int requestId { get; set; }
//        public string? Description { get; set; }
//        [ForeignKey("Booking")]
//        public int BookingId { get; set; }
//        public virtual Booking Booking { get; set; }
//        public typeStatus requestStatus { get; set; }
        
//        [ForeignKey("Admin")]
//        public int AdminId { get; set; }
//        public virtual Admin Admin { get; set; }

//    }
//    public enum typeStatus
//    {
//        Accept,
//        Reject,
//        notSpecify
//    }
//}
