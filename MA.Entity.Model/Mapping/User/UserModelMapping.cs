using MA.Entity.Model.Mapping.Base;
using MA.Entity.Model.Model.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MA.Entity.Model.Mapping.User
{
    public class UserModelMapping : BaseModelMapping<UserModel>
    {
        public override void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable("User", "dbo");
            builder.HasKey(x => x.Id);
        }
    }
}
