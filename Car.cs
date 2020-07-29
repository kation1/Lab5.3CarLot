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
            return String.Format("\t{0,4}\t{1,8}{2,6}{3,15:C2}", Make, Model, Year, Price);

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
            return String.Format("\t{0,4}\t{1,8}{2,6}{3,15:C2}  (Used){4,10:N2} miles",Make,Model,Year,Price,Mileage);
        }
    }
}
