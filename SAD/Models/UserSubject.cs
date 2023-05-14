namespace SAD.Models
{
    public class UserSubject
    {
        //USER SECTION
        public string UserId { get; set; }
        public CustomUserModel User { get; set; }

        //SUBJECT SECTION
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        //True for tutors, false for students
        public bool IsTeachable { get; set; } 
    }
}
