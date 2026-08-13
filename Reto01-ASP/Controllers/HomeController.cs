using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Reto01_ASP.Models;

namespace Reto01_ASP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}