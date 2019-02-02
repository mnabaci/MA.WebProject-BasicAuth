using MA.Entity.Model.Mapping.User;
using MA.Entity.Model.Model.User;

namespace MA.Entity.Core.Context
{

    using Microsoft.EntityFrameworkCore;

    public class DefaultDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=DefaultDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserModelMapping());
        }


        public virtual DbSet<UserModel> Users { get; set; }
    }
}
