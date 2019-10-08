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
        public bool Exists {get; set;}

         public int ID { get; }
        public  int totalPrice{get;set;}
        public  int totalVolume{get;set;}
        private static List<Parcel> _instances = new List<Parcel>{};
    
    public Parcel(int ParcelWeight, int ParcelLength, int ParcelWidth, int ParcelHeight)
    {
        Weight = ParcelWeight;
        Length = ParcelLength;
        Width = ParcelWidth;
        Height = ParcelHeight;
        totalVolume = Volume();
        totalPrice= CostToShip();
        Exists = true;
        
         ID = _instances.Count +1;
         
        _instances.Add(this);
    }
    public static List<Parcel> GetAll()
    {
      return _instances;
    } 
    public int Volume()
    {
        totalVolume =  Length * Width * Height;
        return totalVolume;
       
    }
    public int CostToShip()
    {
        totalPrice =  totalVolume * Weight;
       return totalPrice;
    }

    public static Parcel Find(int searchId)
    {
      return _instances[searchId-1];
    }

    }
}