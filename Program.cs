using System;

namespace Lab5._3CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Where you want to shop? Dave's or Kathryn's?");
           // userLotChoice = Console.ReadLine();

            //CarLot Dave = new CarLot("Dave's Cars");
            CarLot Kathryn = new CarLot("Kat");
            Car newcar = new UsedCar();
           // Dave.AddCar(newcar);
            Kathryn.AddCar(newcar);

            for (int i = 0; i < 12; i++)
            {
                Car recentcar = new Car("Chevy", "Corvette", 2000 + i, 50000m);
                //Dave.AddCar(recentcar);
                Kathryn.AddCar(recentcar);
            }

            int input = 0;
            do
            {
                Console.Clear();

                Kathryn.DisplayMenu();
                //Console.WriteLine($"Select an input:");
                //string userInput = Console.ReadLine();
                input = GetInteger("Select an input: ", Kathryn);
                if (input <= Kathryn.Inventory.Count)
                {
                    Kathryn.BuyaCar(input);
                }
                else if (input == Kathryn.Inventory.Count+2)
                {
                    Console.WriteLine("Thank you for shopping");

                }
                else if (input == Kathryn.Inventory.Count+1)
                {
                    Kathryn.AddCar(Kathryn.GetInfo());
                }
            } while (input != Kathryn.Inventory.Count+2);
        }
        static int GetInteger(string quest, CarLot lot)
        {
            int num;
            bool isValid;
            do
            {
                Console.Write(quest);
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (!isValid)
                {
                    Console.WriteLine("That was not a valid input please enter an integer");
                }
                if (num >= lot.Inventory.Count+3)
                {
                    Console.WriteLine("Not a valid number.");
                }
            } while (!isValid);
            return num;
        }

    }
}
