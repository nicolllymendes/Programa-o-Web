using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using uninove.web.Models;

namespace uninove.web.Controllers;

public class HomeController : Controller
        return 
public IActionResult Boletim()



    ViewBag.Disciplinas = new List<string>()

    {
        "Matemática",
        "Português",
        "História",
        "Biologia"
    };

    ViewBag.Notas = new List<double>()

    {
        9,
        7,
        5,
        4
    };

    return View();

