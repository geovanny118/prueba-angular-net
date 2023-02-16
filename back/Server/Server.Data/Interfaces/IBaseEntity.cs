using System;


namespace Server.Data
{
    public interface IBaseEntity
    {

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }

        public string CreatedBy { get; set; }

        public void SetUserCreate(string username);

        public void SetUserUpdate(string username);
    }
}
