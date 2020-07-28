using System;
using System.Collections.Generic;

namespace Lab5._3CarLot
{
    class Program
    {

        static int LotChoice()
        {
            Console.WriteLine("Where you want to shop? Dave's or Kathryn's?");
            string userLotChoice = Console.ReadLine();
            int location = -1;

            if (userLotChoice == "Kathryn")
            {
                location = 0;
                return location;
            }
            else if (userLotChoice == "Dave")
            {
                location = 1;
                return location;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            CarLot Kathryn = new CarLot("Kat's Kars");
            CarLot Dave = new CarLot("Dave's Cars");
            int location= 0;


            Car newcar = new UsedCar();
            CarLot.Lots[location].AddCar(newcar);

            for (int i = 0; i < 12; i++)
            {
                Car recentvette = new Car("Chevy", "Corvette", 2000 + i, 50000m);
                Car recentMustang = new Car("Ford", "Mustang", 2000 + i, 50000m);
                CarLot.Lots[1].AddCar(recentvette);
                CarLot.Lots[0].AddCar(recentMustang);
            }


           
            do
            {
                int input = 0;
                location = LotChoice();
                if (location == 1 || location == 0)
                {
                    do
                    {

                        Console.Clear();

                        CarLot.Lots[location].DisplayMenu();
                        input = GetInteger("Select an input: ", CarLot.Lots[location]);
                        if (input <= CarLot.Lots[location].Inventory.Count)
                        {
                            CarLot.Lots[location].BuyaCar(input);
                        }
                        else if (input == CarLot.Lots[location].Inventory.Count + 2)
                        {
                            Console.WriteLine("Thank you for shopping");

                        }
                        else if (input == CarLot.Lots[location].Inventory.Count + 1)
                        {
                            CarLot.Lots[location].AddCar(CarLot.Lots[location].GetInfo());
                        }
                    } while (input != CarLot.Lots[location].Inventory.Count + 2);
                }
            } while (location != -1);
           
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
