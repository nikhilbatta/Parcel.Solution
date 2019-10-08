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

         [HttpPost("/parcel/find")]
        public ActionResult ParcelSearchResult(int ID)
        {
            Parcel foundParcel = Parcel.Find(ID);
            return View(foundParcel);
        }
    }
}