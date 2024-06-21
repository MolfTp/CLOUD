using Microsoft.EntityFrameworkCore;

namespace CLOUD.Models.DBContext.Admin
{
    public class Admin: DbContext
{
    public Admin(DbContextOptions<Admin> options) : base(options)
        {
        }

        public DbSet<Admin> Users { get; set; }
    }
}
}
