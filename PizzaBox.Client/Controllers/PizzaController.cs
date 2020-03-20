using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  public class PizzaController : Controller
  {
    [HttpGet]
    public IActionResult Read()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View(new PizzaViewModel());
    }

    [HttpPost]
    public IActionResult Create(PizzaViewModel pizzaViewModel)
    {
      return View();
    }
  }
}
