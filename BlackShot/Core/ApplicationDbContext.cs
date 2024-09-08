using Core.Auth.Model;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=blackshot;Username=zen-life-021212;Password=zenforlife");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<CharacterInfoModel> CharacterInfoModel { get; set; }
    }
}