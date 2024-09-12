using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shortly_Client.Data.ViewModels;

namespace Shortly_Client.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var newUrl = new PostUrlVM();
        return View(newUrl);
    }

    public IActionResult ShortenUrl(PostUrlVM postUrlVm)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", postUrlVm);
        }
        return RedirectToAction("Index");
    }
    
}