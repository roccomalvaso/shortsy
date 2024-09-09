using Microsoft.AspNetCore.Mvc;
using Shortly_Client.Data.Models;

namespace Shortly_Client.Controllers;

public class UrlController : Controller
{
    // GET
    public IActionResult Index()
    {
        //Data is from DB
        var urlDb = new Url()
        {
            Id = 1,
            OriginalLink = "https://google.com",
            ShortLink = "shortly",
            NrOfClick = 1,
            UserId = 1,
        };
        var allData = new List<Url>();
        allData.Add(urlDb);
        
        return View(allData);
    }
}