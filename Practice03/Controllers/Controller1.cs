using Microsoft.AspNetCore.Mvc;

namespace Practice03.Controllers;

public class Controller1 : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}