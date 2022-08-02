using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class DinersController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public DinersController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Diners.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Diner diner)
    {
      _db.Diners.Add(diner);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Diner thisDiner = _db.Diners.FirstOrDefault(diner => diner.DinerId == id);
      return View(thisDiner);
    }

    public ActionResult Edit(int id)
    {
      var thisDiner = _db.Diners.FirstOrDefault(diner => diner.DinerId ==id);
      return View(thisDiner);
    }

    [HttpPost]
    public ActionResult Edit(Diner diner)
    {
      _db.Entry(diner).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisDiner = _db.Diners.FirstOrDefault(diner => diner.DinerId == id);
      return View(thisDiner);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDiner = _db.Diners.FirstOrDefault(diner => diner.DinerId == id);
      _db.Diners.Remove(thisDiner);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}