using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public CuisinesController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      return View(model);
    }
  }
}