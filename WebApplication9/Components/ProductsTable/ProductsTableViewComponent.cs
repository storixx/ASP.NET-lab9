using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Components.ProductsTable;

public class ProductsTableViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(IEnumerable<Product> products = null)
    {
        if (products == null)
        {
            products = new List<Product>
            {
                new Product { ID = 1, Name = "Product 1", Price = 11.11M },
                new Product { ID = 2, Name = "Product 2", Price = 22.22M },
                new Product { ID = 3, Name = "Product 3", Price = 33.33M }
            };
        }

        return View(products);
    }
}