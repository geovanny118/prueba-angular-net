using System;

namespace Server.Data.Models
{
    public class AuditProperties
    {
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Fecha de modificación del registro
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Ultimo usuario que hizo una modificación
        /// </summary>
        public string? ModifiedBy { get; set; }

        /// <summary>
        /// Usuario qeu creo el registro
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Actualiza el nombre del usuario que dispara la creación
        /// </summary>
        /// <param name="username">Nombre del usuario en el sistema</param>
        public void SetUserCreate(string username)
        {
            CreatedBy = username;
            ModifiedBy = username;
            ModifiedOn = CreatedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// Actualiza el nombre del usuario que dispara la actualizacion
        /// </summary>
        /// <param name="username">Nombre del usuario en el sistema</param>
        public void SetUserUpdate(string username)
        {
            if (CreatedOn == null || string.IsNullOrEmpty(CreatedBy))
            {
                CreatedOn = DateTime.UtcNow;
                CreatedBy = username;
            }

            ModifiedBy = username;
            ModifiedOn = DateTime.UtcNow;
        }
    }
}
