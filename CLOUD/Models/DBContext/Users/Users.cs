using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CLOUD.Models.DBContext.Users
{
    public class Users
    {
        [Key]
        public int U_Id { get; set; }  // Unique identifier for the user

        [Required]
        [StringLength(50)] // Limit name length to prevent overflow issues
        public string U_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress] // Ensure valid email format
        public string Email { get; set; }

        [Required]
        [MinLength(8)] // Minimum password length for better security
        [JsonIgnore] // Exclude password from serialization for security
        public string PasswordHash { get; set; }  // Store hashed password, not plain text

        [Required]
        [CompareProduuct("PasswordHash", ErrorMessage = "Passwords do not match")] // Validate password confirmation
        [JsonIgnore]
        public string ConfirmPassword { get; set; }  // Temporary property for registration

        [Required]
        public int Contact { get; set; }  // Consider using a dedicated class for phone numbers with validation

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // Automatic timestamp for user creation    
    }
}
