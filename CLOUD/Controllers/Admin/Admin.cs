using Microsoft.AspNetCore.Mvc;

namespace CLOUD.Controllers.Admin
{
    public class Admin : Controller
    {
        private readonly Admin _context;

        public Admin(Admin context)
        {
            _context = context;
        }

        public IActionResult AdminPage()
        {
            if (User.IsInRole("Admin")) // Check for "Admin" role
            {
                return View(); // Display admin-specific content
            }

            return RedirectToAction("Index"); // Redirect non-admins
        }
    }
}
