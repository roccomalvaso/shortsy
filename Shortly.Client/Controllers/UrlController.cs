using Microsoft.AspNetCore.Mvc;
using Shortly_Client.Data.Models;

namespace Shortly_Client.Controllers;

public class UrlController : Controller
{
    // GET
    public IActionResult Index()
    {
        //Fake DB Data
        var allUrls = new List<Url>()
        {
            new Url()
            {
                Id = 1,
                OriginalLink = "https://google.com",
                ShortLink = "lil.ly/834h",
                NrOfClick = 100,
                UserId = 12
            },
            new Url()
            {
                Id = 2,
                OriginalLink = "https://google.com",
                ShortLink = "lil.ly/34243",
                NrOfClick = 12,
                UserId = 13
            },
            new Url()
            {
                Id = 3,
                OriginalLink = "https://google.com",
                ShortLink = "lil.ly/u324h",
                NrOfClick = 3,
                UserId = 14
            }
        };
        return View(allUrls);
    }

    public IActionResult Create()
    {
        return RedirectToAction("Index");
    }
}