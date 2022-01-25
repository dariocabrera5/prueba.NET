using Microsoft.AspNetCore.Mvc;
using webApp.Models.Data;
using System.Linq;

namespace webApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        public ProductController(DataContext context){
            _context = context;
        }
        public IActionResult index(){
            var product = _context.Products.ToList();
            return View();
        }
    }
}