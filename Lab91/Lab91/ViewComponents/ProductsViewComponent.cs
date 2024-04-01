using Microsoft.AspNetCore.Mvc;
using Lab91.Models;
using System.Collections.Generic;

namespace Lab91.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<Product> products)
        {
            return View(products);
        }
    }
}