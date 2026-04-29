using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP1BIS_SISRO_MOGUELEVSKY.Models;

namespace TP1BIS_SISRO_MOGUELEVSKY.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Complejo complejo = new Complejo();
        ViewBag.cabañas = grupo.DevolverCabaña();
        return View();
    }
    public IActionResult infoCabaña(int id)
    {
        Complejo complejo = new Complejo();
        ViewBag.cabañas[id] = grupo.GetCabaña();
        return infoCabaña();
    }

    public IActionResult Privacy()
    {

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
