using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

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
      Parcel newParcel = new(length, width, height, weight);
      // int newVolume = newParcel.Volume();
      // int newCost = newParcel.CostToShip(newVolume);
      return RedirectToAction("Index", newParcel);
    }

    [HttpGet("/estimate")]
    public ActionResult Index()
    {
      
      return View();
    }
  }
}