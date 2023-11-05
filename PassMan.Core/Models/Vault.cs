using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace PassMan.Core.Models
{
    [Table("Vault")]
    public class Vault
    {
        [Key, Required, Browsable(false)]
        public int? Id { get; set; }

        [ForeignKey("User"), Required, Browsable(false)]
        public string UserId { get; set; }

        [Required, DisplayName("Username")]
        public string Username { get; set; }

        [Required, DisplayName("Password")]
        public string Password { get; set; }

        [Required, DisplayName("Website")]
        public string Website { get; set; }

        public Vault() { }
        public Vault (int Id, string UserId, string Username, string Password, string Website)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.Username = Username;
            this.Password = Password;
            this.Website = Website;
        }

        public Vault (Vault obj)
        {
            this.Id = obj.Id;
            this.UserId = obj.UserId;
            this.Password = obj.Password;
            this.Username = obj.Username;
            this.Website = obj.Website;
        }
    }
}
