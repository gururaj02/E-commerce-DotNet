using E_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        // This will helps to create table in DB (Products is the name of the table in DB)
        public DbSet<Product> Products { get; set; }
    }
}
