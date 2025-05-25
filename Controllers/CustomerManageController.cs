using Microsoft.AspNetCore.Mvc;
using POS.Data;
using POS.DataModel;

namespace POS.Areas.Admin.Controllers
{
    [Route("CustomerManage")]
    public class CustomerManageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerManageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("AddCustomer")]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer(Customers customer)
        {
            if (ModelState.IsValid)
            {   
                _context.Add(customer);
                _context.SaveChanges();
                TempData["Message"] = "Customer Added Successfully.";
                return RedirectToAction("AddCustomer");
            }

           return View(customer);

        }

        [Route("CustomerList")]
        public IActionResult CustomerList()
        {
            var data = _context.Customers.ToList();
            return View(data);  
        }
    }
}
