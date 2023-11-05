using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace PassMan.Core.Models
{
    [Table("Vault")]
    public class Vault
    {
        [Key, Required]
        public int Id { get; set; }

        [ForeignKey("User"), Required]
        public string UserId { get; set; }

        [Required, DisplayName("Password")]
        public string Password { get; set; }

        [Required, DisplayName("Username")]
        public string Username { get; set; }

        [Required, DisplayName("Website")]
        public string Website { get; set; }

        [Browsable(false)]
        public User user { get; set; }

    }
}
