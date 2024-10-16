using Microsoft.AspNetCore.Mvc;

namespace animodle.Controllers.Classic;

public class ClassicController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}