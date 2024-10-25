using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class ProLanguageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}