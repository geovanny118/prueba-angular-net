using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models
{
    [Table("DocumentKeywords")]
    public class Rol : BaseEntity
    {
        public int? ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUsers { get; set; }

        public string RoleType { get; set; }
    }
}