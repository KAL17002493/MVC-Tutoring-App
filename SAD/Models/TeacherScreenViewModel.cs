namespace SAD.Models
{
    public class TeacherScreenViewModel
    {
        public List<CustomUserModel> PublicTeachers { get; set; }
        public List<CustomUserModel> FollowedTeachers { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
