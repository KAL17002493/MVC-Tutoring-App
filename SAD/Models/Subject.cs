using System.ComponentModel.DataAnnotations;

namespace SAD.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<UserSubject> UserSubjects { get; set; }
    }
}
