using CLOUD.Models.DBContext;
using Microsoft.AspNetCore.Mvc;

namespace CLOUD.Controllers.Register
{
    public class Register : Controller
    {
        private readonly Register _context;

        public Register(Register context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View(); // Return the Register view
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                user.PasswordHash = HashPassword(user.Password); // Hash password before saving

                // Implement logic to check for duplicate email (optional)
                if (_context.User.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists.");
                    return View(user);
                }

                _context.User.Add(user);
                await _context.SaveChangesAsync();

                // Send registration confirmation email (optional)

                return RedirectToAction("RegistrationConfirmation"); // Redirect to confirmation page
            }

            return View(user); // Return the Register view with validation errors
        }

        private string HashPassword(string password)
        {
            // Implement logic to hash the password using a secure hashing algorithm (e.g., bcrypt)
            // You can use a library like BCrypt.Net for this purpose
            return BCrypt.Net.BCrypt.HashPassword(password); // Example using BCrypt.Net
        }
    }
}
