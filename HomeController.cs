using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        SRS SRS1 = new SRS(8/04/2023, "10.3.7", "template_project", "luana victoria");

        List<SRS> listaSRS = new List<SRS>();
        listaSRS.Add(SRS1);
        
        ViewBag.listaSRS = listaSRS;


        return View();
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
