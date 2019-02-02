namespace MA.Entity.Core.Context
{
    using MA.Entity.Model.Mapping;
    using MA.Entity.Model.Model;

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
            modelBuilder.ApplyConfiguration(new TestModelMapping());
        }


        public DbSet<TestModel> Students { get; set; }
    }
}
