using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/form")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/estimate")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel newParcel = new Parcel(length, width, height, weight);
      // int newVolume = newParcel.Volume();
      // int newCost = newParcel.CostToShip(newVolume);
      return RedirectToAction("Index", newParcel);
    }

    [HttpGet("/estimate")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
  }
}