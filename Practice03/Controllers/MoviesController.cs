using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Practice03.Controllers;

public class MoviesController : Controller
{
    // GET: /MoviesController/
    public IActionResult Index()
    {
        return View();
    }
}