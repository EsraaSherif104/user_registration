using Microsoft.EntityFrameworkCore;

namespace user_registration.Models
{
    public class UserDbcontext : DbContext
    {
        public UserDbcontext(DbContextOptions<UserDbcontext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
