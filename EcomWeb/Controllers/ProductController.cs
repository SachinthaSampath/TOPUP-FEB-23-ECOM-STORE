using EcomWeb.DB;
using EcomWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcomWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext ctx;

        public ProductController(ApplicationDbContext db)
        {
            this.ctx = db;
        }
        public IActionResult Index()
        {
           IEnumerable<Product> ProductsList =   this.ctx.products;
            return View(ProductsList);
        }
    }
}
