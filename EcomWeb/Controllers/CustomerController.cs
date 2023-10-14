using EcomWeb.DB;
using EcomWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace EcomWeb.Controllers
{
    public class CustomerController : Controller
    {
        //carete a variable to hold the db context object
        private readonly ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext db)
        {   //the db context object for our application will be passed to the constructor as an argument
            //the passed argument is assigned to the variable we created earlier
            this._db = db;
        }

        public IActionResult Index()
        {
            //when the Index action runs, take the customers from the db through the variable
            //referncin to the db context object
            IEnumerable<Customer> listOfCustomers =  this._db.customers;
            return View(listOfCustomers);
        }

        public IActionResult Prabasha()
        {
            return View();
        }
    }
}
