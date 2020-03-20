using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class PizzaBoxRepository
  {
    private PizzaBoxDbContext _db;

    public PizzaBoxRepository(PizzaBoxDbContext dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<T> Read<T>() where T : class
    {
      return _db.Set<T>();
    }

    public object CheckAccount(string user, string pass)
    {
      return new object();
    }
  }
}
