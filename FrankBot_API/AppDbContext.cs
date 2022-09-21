using Microsoft.EntityFrameworkCore;
using FrankBot_API.Models;

namespace FrankBot_API
{
    public class AppDbContext: DbContext
    {
        public DbSet<Users> User { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
