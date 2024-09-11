using Microsoft.AspNetCore.Mvc;
using Shortly_Client.Data.Models;

namespace Shortly_Client.Controllers;

public class UrlController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return RedirectToAction("Index");
    }
}