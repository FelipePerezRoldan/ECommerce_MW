using Ecommerce_MW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_MW.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; } //Most have the name of the field in plural

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Indexation of filds that have the db
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();//c cause is referent to country
        }
    }
}
