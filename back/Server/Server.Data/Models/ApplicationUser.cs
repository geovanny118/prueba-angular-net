using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models
{
    [Table("ApplicationUsers")]
    public class ApplicationUser : BaseEntity
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string CivilStatus { get; set; }

        public bool HasBrothers { get; set; }

        public bool State { get; set; }

        public virtual List<Rol> Roles { get; set; }

    }
}
