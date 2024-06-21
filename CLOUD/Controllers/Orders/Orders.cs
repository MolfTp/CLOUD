using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CLOUD.Controllers.Orders
{
    public class Orders : Controller
    {
        {
    var data = (from o in _context.Orders
                join p in _context.Products on o.ProductId equals p.ProductId
                join c in _context.Classes on p.ClassId equals c.ClassId
                select new OrderProductClassViewModel
                {
                    OrderId = o.OrderId,
                    OrderDate = o.OrderDate.ToString("dd/MM/yyyy"), // Example formatting
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    ClassName = c.ClassName
                }).ToList();

    return View(data);
    }
}
