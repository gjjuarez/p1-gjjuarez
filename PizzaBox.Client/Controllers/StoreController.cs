using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class StoreController : Controller
  {
    [HttpGet]
    public IActionResult History()
    {
      return View("Store");
    }
  }
}
