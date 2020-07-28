using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3CarLot
{
    class CarLot
    {
        public List<Car> Inventory = new List<Car>();
        public string Name { get; set; }

        public CarLot(string aName)
        {
            Name = aName;
        }


        public void AddCar(Car newcar)
        {
            Inventory.Add(newcar);
            //Console.WriteLine($"Car added to inventory of {Name}");
        }

        public void DisplayMenu()
        {
            DisplayInventory();
            Console.WriteLine($"{Inventory.Count + 1}. Add a Car\n{Inventory.Count +2} Quit");
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
            Console.WriteLine("Make:");
            string make = Console.ReadLine();
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            Console.WriteLine("year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Milage:");
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
