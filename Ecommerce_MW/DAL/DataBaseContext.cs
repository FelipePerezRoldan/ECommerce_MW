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
    }
}
