namespace MA.Entity.Model.Model.Base
{
    using System;

    public class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
