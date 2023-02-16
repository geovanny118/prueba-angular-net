using System;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models
{
    [Table("UserDetails")]
    public class UserDetails : AuditProperties
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public string UserId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool IsActive { get; set; }
    }
}
