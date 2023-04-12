using System.ComponentModel.DataAnnotations;

namespace SAD.Models
{
    public class TeacherModel
    {
        public CustomUserModel User { get; set; }

        [Required]
        public bool Available { get; set; } = true;

        public string About { get; set; }

        public string teacherCode { get; set; }
    }
}
