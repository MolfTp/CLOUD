using Microsoft.AspNetCore.Mvc;

namespace CLOUD.Controllers.LogIn
{
    public class LogIn : Controller
    {
        private readonly LogIn _context;

        public LogIn(LogIn context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View(); // Return the Login view
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.User.FirstOrDefaultAsync(u => u.Email == email);

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash)) // Validate password hash
                {
                    // Login successful (store user information in session or cookie if needed)
                    return RedirectToAction("Index", "Home"); // Redirect to designated page
                }

                ModelState.AddModelError(string.Empty, "Invalid login credentials.");
            }

            return View(); // Return the Login view with error message (if any)
        }
    }
}
