using System.ComponentModel.DataAnnotations;

namespace SAD.Models
{
    public class FollowModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FollowerId { get; set; }

        [Required]
        public string FollowingId { get; set; }

        public CustomUserModel Follower { get; set; }
        public CustomUserModel Following { get; set; }
    }
}
