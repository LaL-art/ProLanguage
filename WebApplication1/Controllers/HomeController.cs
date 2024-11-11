using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Home Page";
        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Us";
        return View();
    }

    public IActionResult Services()
    {
        ViewData["Title"] = "Our Services";
        return View();
    }

    public IActionResult SignUp()
    {
        ViewData["Title"] = "Sign Up";
        return View();
    }
    public IActionResult SignIn()
    {
        ViewData["Title"] = "Sign In";
        return View();
    }
}
