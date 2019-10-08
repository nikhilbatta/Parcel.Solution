using System;
using System.Collections.Generic;

namespace Shipping.Models
{
    public class Parcel
    {
        public int Weight{get;set;}
        public int Length{get;set;}
        public int Width{get;set;}
        public int Height{get;set;} 

         public int ID { get; }
        public static int totalPrice{get;set;}
        public static int totalVolume{get;set;}
        private static List<Parcel> _instances = new List<Parcel>{};
    
    public Parcel(int ParcelWeight, int ParcelLength, int ParcelWidth, int ParcelHeight)
    {
        Weight = ParcelWeight;
        Length = ParcelLength;
        Width = ParcelWidth;
        Height = ParcelHeight;
        totalPrice= 0;
        totalVolume = 0;
         ID = _instances.Count +1;
        _instances.Add(this);
    }
    public static List<Parcel> GetAll()
    {
      return _instances;
    } 
    public void Volume()
    {
        totalVolume =  Length * Width * Height;
       
    }
    public void CostToShip()
    {
        totalPrice =  totalVolume * Weight;
       
    }

    public int returnVolume()
    {
         return totalVolume;
    }

    public int returnPrice()
    {
         return totalPrice;
    }

    public static Parcel Find(int searchId)
    {
      return _instances[searchId-1];
    }

    }
}