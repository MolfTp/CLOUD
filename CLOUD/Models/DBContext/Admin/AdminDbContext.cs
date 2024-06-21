using Microsoft.EntityFrameworkCore;

namespace CLOUD.Models.DBContext.Admin
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; } // Assuming a dedicated "Admin" model
    }
}
