using Microsoft.AspNetCore.Mvc;

namespace CLOUD.Controllers.Admin
{
    public class AdminLoop : Controller
    {
        private readonly AdminLoop _context;

        public AdminLoop(AdminLoop context)
        {
            _context = context;
        }

        public IActionResult Admins()
        {
            var admins = _context.Users.Where(u => u.Role == "Admin").Include(u => u.Orders).ToList(); // Include Orders collection
            return View(admins); // Pass admins with included orders to the view
        }
    }
}
