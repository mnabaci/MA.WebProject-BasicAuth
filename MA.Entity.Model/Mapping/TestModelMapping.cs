namespace MA.Entity.Model.Mapping
{
    using MA.Entity.Model.Mapping.Base;
    using MA.Entity.Model.Model;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TestModelMapping : BaseModelMapping<TestModel>
    {
        public override void Configure(EntityTypeBuilder<TestModel> builder)
        {
            builder.ToTable("testTable");

            builder.HasKey(t => t.Id);
        }
    }
}
