using System.ComponentModel.DataAnnotations;

namespace CLOUD.Models.DBContext.Users
{
    public class EmailVerification
    {
        public int Id { get; set; } // Primary key for the user

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)] // Example validation rule for password (for security measures)
        public string PasswordHash { get; set; } // Store hashed password for security

        public string VerificationToken { get; set; } // Token for email verification

        public bool IsEmailVerified { get; set; } = false; // Flag indicating email verification status

        // Additional user properties (e.g., Name, Phone number)
    }
}
