namespace SAD.Models
{
    public class TutorAvailability
    {
        public int Id { get; set; }
        public string TutorId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
