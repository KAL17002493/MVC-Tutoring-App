using System.ComponentModel.DataAnnotations;

namespace SAD.Models
{
    public class FollowModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FollowerId { get; set; }  // the user ID of the followER

        [Required]
        public string FollowingId { get; set; } //Uuser ID of the followING

        public CustomUserModel Follower { get; set; }  //Navigation property to the follower user

        public CustomUserModel Following { get; set; } //Navigation property to the following user
    }
}
