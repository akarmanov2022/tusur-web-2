using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web_1.Models;

namespace web_1.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
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

    public IActionResult Task1()
    {
        ViewBag.Count = 1;
        return View();
    }

    public IActionResult Task2()
    {
        return View();
    }
}