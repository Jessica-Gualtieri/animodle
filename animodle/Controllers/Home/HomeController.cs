using Microsoft.AspNetCore.Mvc;

namespace animodle.Controllers.Home;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}