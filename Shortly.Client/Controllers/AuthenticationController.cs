using Microsoft.AspNetCore.Mvc;
using Shortly_Client.Data.ViewModels;

namespace Shortly_Client.Controllers;

public class AuthenticationController : Controller
{
    public IActionResult Users()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult LoginSubmitted(LoginVM loginVm)
    {
        if (!ModelState.IsValid)
        {
            return View("Login", loginVm);
        }
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Register()
    {
        return View(new RegisterVM());
    }

    public IActionResult RegisterUser(RegisterVM registerVm)
    {
        if (!ModelState.IsValid)
        {
            return View("Register", registerVm);
        }
        return RedirectToAction("Index", "Home");
    }
}