using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections.Generic;
using System.IO;

namespace Shipping.Controllers
{
    public class ParcelController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Parcel> allParcels = Parcel.GetAll();
            return View(allParcels);
        }
        [HttpGet("/parcels/new")]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost("/singleparcel")]
        public ActionResult ShowSingleParcel(int ParcelWeight, int ParcelHeight, int ParcelLength, int ParcelWidth)
        {
            Parcel myParcel = new Parcel(ParcelWeight,ParcelHeight,ParcelLength,ParcelWidth);
         
            return View(myParcel);
        }

        [HttpGet("/findParcels")]
        public ActionResult Find()
        {
            return View();
        }
        [HttpGet("/Error")]
        public ActionResult ShowError()
        {
            return View();
        }

         [HttpPost("/parcel/find")]
        public ActionResult ParcelSearchResult(int ID)
        {
            
            List<Parcel> count = Parcel.GetAll();
            if(ID <= count.Count)
            {
                Parcel foundParcel = Parcel.Find(ID);
                return View(foundParcel);
            }
            else
            {
                 return RedirectToAction("ShowError");
            }
        }
    }
}