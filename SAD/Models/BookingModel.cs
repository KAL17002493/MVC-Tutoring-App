using System.ComponentModel.DataAnnotations.Schema;
using static SAD.Models.Enums;

namespace SAD.Models
{
    public class BookingModel
    {
        public string Id { get; set; }
        [ForeignKey("TutorId")]
        public CustomUserModel Tutor { get; set; }
        [ForeignKey("StudentId")]
        public CustomUserModel Student { get; set; }
        public DateTime TimeSlot { get; set; }
        public BookingStatus Status { get; set; }

        public string TutorId { get; set; }
        public string StudentId { get; set; }


    }
}
