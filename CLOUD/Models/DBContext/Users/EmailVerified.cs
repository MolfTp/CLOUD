using Microsoft.EntityFrameworkCore;

namespace CLOUD.Models.DBContext.Users
{
    public class EmailVerified : DbContext
    {
        public EmailVerified(DbContextOptions<EmailVerified> options) : base(options)
        {
        }

        public DbSet<EmailVerification> Users { get; set; } // Assuming "Users" table in database
    }
}
