using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class UserController : Controller
  {
    [HttpGet]
    public IActionResult History(int userId)
    {
      return View("User");
    }

    [HttpGet]
    public IActionResult Order()
    {
      return View("User");
    }
  }
}
