using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Reto01_ASP.Models;

namespace Reto01_ASP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["NombreEstudiante"] = "Bryan Escobar";
    ViewData["Carrera"] = "Ingenieria de Software";
    ViewData["Materia"] = "Desarrollo Multiplataforma de Aplicaciones Web";
    ViewData["Seccion"] = "A";
        return View();
    }
}