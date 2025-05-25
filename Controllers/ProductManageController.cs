using Microsoft.AspNetCore.Mvc;
using POS.Data;
using POS.DataModel;

namespace POS.Areas.Admin.Controllers
{
    [Route("ProductManage")]
    public class ProductManageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductManageController(ApplicationDbContext context)
        {
            _context = context;
        }



        [Route("AddProduct")]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                TempData["Message"] = "Product added successfully!";
                return RedirectToAction("AddProduct");
            }

            return View(product);
        }

        [Route("ProductList")]
        public IActionResult ProductList()
        {

            var data = _context.Products.ToList();
            return View(data);
        }
    }
}
