using Microsoft.AspNetCore.Mvc;

namespace Shortly_Client.Controllers;

public class AuthenticationController : Controller
{
    public IActionResult Users()
    {
        return View();
    }
}