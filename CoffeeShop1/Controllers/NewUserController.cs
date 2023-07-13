using CoffeeShop1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CoffeeShop1.Controllers;

public class NewUserController : Controller
{
    private List<NewUser> userInfo = new List<NewUser> { };
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Results(NewUser customer)
    {
        return View(customer);
    }
    public IActionResult Registration()
    {
        return View();
    }
    [HttpPost]
    public IActionResult FormSubmit(NewUser customer)
    {
        return RedirectToAction("Results", customer);
    }
}
    

