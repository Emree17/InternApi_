using InternAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InternAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB; Database=InternshipManagement; Trusted_Connection=True;");
        }

        public DbSet<Sirket> managers { get; set; }
    }
}