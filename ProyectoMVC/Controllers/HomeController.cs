using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Models;
using ProyectoMVC.Models.ViewModel;

namespace ProyectoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.Plan1 = "Plan Básico";
        ViewBag.Desc = "Solo incluye el servicio de Ideas Tecnológicas";
        ViewBag.Precio = "RD$ 3,500.00";
        ViewBag.Metodo="Único Pago";

        ViewData["Plan2"] = "Plan Intermedio";
        ViewData["Desc2"] = "Incluye servicios de Ideas Tecnológicas y SEO";
        ViewData["Precio2"] = "RD$ 5,800.00";
        ViewData["Metodo2"] = "Pago Mensual";

        var DetallesModel = new List<DetallesModel>(){
            new DetallesModel{
                plan3 = "Plan Avanzado",
                Desc3 = "Incluye servicios de Ideas Tecnológicas, SEO y Marketing",
                precio3 = "RD$ 9985.00",
                metodo3 = "Pago Anual"}
        };

        var M1ViewModel = new M1ViewModel{
            DetallesModels = DetallesModel
        };

        return View("Privacy", M1ViewModel);
    }

    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
}