using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<object> objects = new()
        {
            new { id = 1, name = "Test" },
            new { id = 1, name = "Test" },
            new { id = 1, name = "Test" }
        };
        ViewBag.objects = objects;
        return View();
    }
}