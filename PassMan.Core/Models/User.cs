using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PassMan.Core.Models
{
    [Table("User")]
    public class User
    {
        [Key, Required]
        public string Username { get; set; }

        [Required, DisplayName("Password")]
        public string Password { get; set; }

        [Required, DisplayName("Email")]
        public string Email { get; set; }

        [Required, DisplayName("Firstname")]
        public string Firstname { get; set; }

        [Required, DisplayName("Lastname")]
        public string Lastname { get; set; }
    }
}