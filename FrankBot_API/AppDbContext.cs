using Microsoft.EntityFrameworkCore;
using FrankBot_API.Models;

namespace FrankBot_API
{
    public class AppDbContext: DbContext
    {
        public DbSet<Users> User { get; set; } = null!;

        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server = localhost; user = root; password = Afina2010; database = usersdb;",
                new MySqlServerVersion(new Version(8, 0, 30)));
        }*/
    }
}
