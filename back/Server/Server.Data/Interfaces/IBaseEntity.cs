using System;


namespace Server.Data
{
    public interface IBaseEntity
    {
        /// <summary>
        /// Id de registro
        /// </summary>
        public int Id { get; set; }

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
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Usuario qeu creo el registro
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        public void SetUserCreate(string username);

        /// <summary>
        /// Actualiza el nombre del usuario que dispara la actualizacion
        /// </summary>
        /// <param name="username">Nombre del usuario en el sistema</param>
        public void SetUserUpdate(string username);
    }
}
