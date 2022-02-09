using FirstCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly DatabaseContext _db;
            public ProductController(DatabaseContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> pList = _db.Products.ToList();
            return View(pList);
        }
    }
}
