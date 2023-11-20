
using Microsoft.EntityFrameworkCore;
using Oganim.Models;

namespace Oganim.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Blogs> Blogs { get; set; }

    }
}
