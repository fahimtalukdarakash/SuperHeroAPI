global using Microsoft.EntityFrameworkCore;
namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-7LAD38R\\SQLEXPRESS;Database=superherodb;Trusted_Connection=true;TrustServerCertificate=Yes;");
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
