namespace MA.Entity.Model.Mapping.Base
{
    using MA.Entity.Model.Model.Base;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class BaseModelMapping<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseModel
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);
    }
}
