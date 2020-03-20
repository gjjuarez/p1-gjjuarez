using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    private PizzaBoxRepository _pbr;

    public PizzaViewModel(PizzaBoxRepository repository)
    {
      _pbr = repository;
    }

    public List<Crust> CrustList { get; set; }
    public List<Size> SizeList { get; set; }
    public List<Topping> ToppingList { get; set; }

    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }

    public PizzaViewModel()
    {
      CrustList = _pbr.Read<Crust>().ToList();
      SizeList = _pbr.Read<Size>().ToList();
      ToppingList = _pbr.Read<Topping>().ToList();
    }
  }
}
