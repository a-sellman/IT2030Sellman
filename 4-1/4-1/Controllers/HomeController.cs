using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using _4_1.Models;
using System.Runtime.CompilerServices;

public class HomeController : Controller
{
    private MovieContext context { get; set; }

    public HomeController(MovieContext ctx)
    {
        context = ctx;
    }

    public IActionResult Index()
    {
        var movies = context.Movies.OrderBy(m => m.Name).ToList();
        return View(movies);
    }
} 
    /*
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
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
*/