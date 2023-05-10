using static SAD.Models.Enums;

namespace SAD.Models
{
    public class BookingModel
    {
        public string Id { get; set; }
        public CustomUserModel TutorId { get; set; }
        public CustomUserModel StudentId { get; set; }
        public DateTime TimeSlot { get; set; }
        public BookingStatus Status { get; set; }


    }
}
