using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Chart.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public Role Role { get; set; } = Role.User;  // Mặc định là "User"

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
    public enum Role
    {
        User,
        Admin,
        Manager
    }
}
