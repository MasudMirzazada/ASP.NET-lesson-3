using HOMETASKORM.DAL;
using HOMETASKORM.Models;
using HOMETASKORM.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOMETASKORM.Controllers
{
    public class HomeController : Controller
    {
        private readonly P224DbContext _context;
        public HomeController(P224DbContext context)
        {
            _context = context;
        }

     
        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            List<Category> categories = _context.Categories.ToList();
            HomeVM homeVM = new HomeVM
            {
                Products=products,
                Categories=categories
            };
            return View(homeVM);
        }
    }
}
