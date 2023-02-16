using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models
{
    [Table("UserRefreshTokens")]
    public class UserRefreshToken
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public string LoginProvider { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }
    }
}
