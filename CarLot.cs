using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3CarLot
{
    class CarLot
    {
        public static List<CarLot> Lots = new List<CarLot>();
        public List<Car> Inventory = new List<Car>();
        public string Name { get; set; }

        public CarLot(string aName)
        {
            Name = aName;
            Lots.Add(this);
        }


        public void AddCar(Car newcar)
        {
            Inventory.Add(newcar);

        }

        public void DisplayMenu()
        {
            Console.WriteLine($"Welcome to {Name}\n");
            Console.WriteLine(String.Format("ID\t{0,4}\t{1,8}{2,6}{3,15}  if Used{4,13}", "Make", "Model", "Year", "Price","Mileage"));
            Console.WriteLine("-------------------------------------------------------------------------");
            DisplayInventory();
            Console.WriteLine($"{Inventory.Count + 1}. Add a Car\n{Inventory.Count +2}. Leave car lot");
        }

        public int HowManyCars()
        {
            return Inventory.Count;
        }

        public void DisplayInventory()
        {
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Inventory[i]}");
            }
     
        }
        public void Removecar(int index)
        {
            Inventory.RemoveAt(index-1);

        }

        public void BuyaCar(int num)
        {
            Console.WriteLine(Inventory[num-1]);
            Console.WriteLine("Do you want to buy it?(y/n)");
            string userChoice = Console.ReadLine();

            if (userChoice == "y" )
            {
                Removecar(num);
                Console.WriteLine("Car sold!");
            }

        }
        public Car GetInfo()
        {
            Console.Write("Make:");
            string make = Console.ReadLine();
            Console.Write("Model:");
            string model = Console.ReadLine();
            Console.Write("year:");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("if mileage is over 100 car will be considered used");
            Console.Write("Milage:");
            int mileage = int.Parse(Console.ReadLine());

            if (mileage > 100)
            {
                UsedCar car = new UsedCar(make, model, year, price, mileage);
                return car;
            }
            else
            {
                Car car = new Car(make, model, year, price);
                return car;
            }
            
        }
    }
}
