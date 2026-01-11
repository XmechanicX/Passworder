using Microsoft.EntityFrameworkCore;
using Passworder.DataBase;
using Passworder.DataBase.Configuration;
using Passworder.Model;

namespace Passworder.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DataFilling> DataFillings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DataFillingConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Username=postgres; Password=***; Database=PasswoderDB");
    }

}