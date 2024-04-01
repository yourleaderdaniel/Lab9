using Lab91.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab91.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Пример создания и передачи списка продуктов в представление
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Product 1", Price = 100M },
                new Product { ID = 2, Name = "Product 2", Price = 200M },
                // Добавьте больше продуктов здесь
            };

            return View(products);
        }
    }
}
