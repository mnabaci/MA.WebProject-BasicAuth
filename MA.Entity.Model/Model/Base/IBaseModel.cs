using System;

namespace MA.Entity.Model.Model.Base
{
    public interface IBaseModel
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
