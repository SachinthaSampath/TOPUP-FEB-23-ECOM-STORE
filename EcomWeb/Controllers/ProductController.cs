using EcomWeb.DB;
using EcomWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Make(Product p)
        {
                this.ctx.products.Add(p);
                this.ctx.SaveChanges();
                return RedirectToAction("Index");    
        }
    }
}
