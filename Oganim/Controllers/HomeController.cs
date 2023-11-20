using Microsoft.AspNetCore.Mvc;
using Oganim.DAL;
using Oganim.Models;
using OganimViewModelds;
using System;

namespace Oganim.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Products> products = _context.Products.ToList();
            List<Departments> departments = _context.Departments.ToList();
            List<Blogs> blogs = _context.Blogs.ToList();


            HomeVM vm = new HomeVM { Blogs = blogs, Products = products, Departments = departments };
            return View(vm);
        }
    }
}

