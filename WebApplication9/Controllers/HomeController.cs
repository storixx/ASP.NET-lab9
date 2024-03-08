using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Products");
    }

    public IActionResult Products()
    {
        return ViewComponent("ProductsTable");
    }


    public async Task<IActionResult> Weather(string city = "Mykolaiv")
    {
        return ViewComponent("Weather", new { city });
    }

}