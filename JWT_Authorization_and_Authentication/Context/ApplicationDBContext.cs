using JWT_Authorization_and_Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_Authorization_and_Authentication.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public virtual DbSet<User> UserInfo { get; set; }

    }

}
