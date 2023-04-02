using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWork.MVC.Models;
using System;

namespace CarWork.MVC.Controllers;

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
        var model = new List<Person>()
        {
            new Person()
            {
                FirstName = "Jakub",
                LastName = "Kozera"
            },
            new Person()
            {
                FirstName = "Adam",
                LastName = "Małysz"
            }
        };

        return View(model);
    }
    public IActionResult About()
    {
        var model = new About()
        {
            Title = "About Title",
            Description = "DE La La LA",
            Tags = new List<string>() {"Łeło", "Łibu łibu"}
        };
        
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}