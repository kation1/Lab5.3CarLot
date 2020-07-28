using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3CarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "empty";
            Model = "unknown";
            Year = 2000;
            Price = 0.00M;
        }

        public Car(string aMake, string aModel, int aYear, decimal aPrice)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
            Price = aPrice;

        }


        public override string ToString()
        {
            if(Model.Length > 7)
            {
                return $"{Make}\t{Model}\t{Year}\t{Price}";
            }
            else
            {
                return $"{Make}\t{Model}\t\t{Year}\t{Price}";
            }
            
        }
    }
    class UsedCar : Car
    {
        public decimal Mileage;
        public UsedCar(string aMake, string aModel, int aYear, decimal aPrice, decimal aMileage) : base( aMake, aModel,  aYear, aPrice)
        {
            Mileage = aMileage;
        }

        public UsedCar() : base()
        {
      
        }

        public override string ToString()
        {
            if (Model.Length > 7)
            {
                return $"{Make}\t{Model}\t{Year}\t{Price}\t(Used)\t{Mileage} miles";
            }
            else
            {
                return $"{Make}\t{Model}\t\t{Year}\t{Price}\t(Used)\t{Mileage} miles";
            }
        }
    }
}
