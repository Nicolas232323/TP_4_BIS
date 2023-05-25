using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_PAGINA_WEB.Models;

namespace TP_PAGINA_WEB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaPaises = info.ListarPaises();
        return View("Index");
    }
    public IActionResult DetallePais(string pais)
    {
        ViewBag.PaisBuscado = info.DetallePais(pais);
        return View("DetallePais");
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
