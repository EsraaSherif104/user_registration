using Microsoft.EntityFrameworkCore;

namespace user_registration.Models
{
    public class UserDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=user_registration;Trusted_Connection=true;TrustServerCertificate=true;");

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }

    }
}
