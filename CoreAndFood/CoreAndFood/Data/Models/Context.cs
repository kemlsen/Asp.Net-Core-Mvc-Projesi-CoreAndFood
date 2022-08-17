using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RF82O7V;Initial Catalog=DbCoreFood;Integrated Security=True");
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
