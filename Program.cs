using System;
using System.Collections.Generic;

namespace Lab5._3CarLot
{
    class Program
    {

        static int LotChoice(List<CarLot> places)
        {
            
            string userLotChoice = "";
            int location = -1;
            bool isValid = false;
            do
            {
                Console.Clear();
                int i = 0;
                for (i = 0; i < places.Count; i++)
                {
                    Console.WriteLine(String.Format("{0,4}. {1,-15}", i + 1, places[i].Name));
                }
                Console.WriteLine("{0,4}. exit", i + 1);
                Console.Write("Where you want to shop?: ");
                userLotChoice = Console.ReadLine();
                isValid = int.TryParse(userLotChoice, out location);
                if (!isValid)
                {
                    continue;
                }
                //if (userLotChoice == "1")
                //{
                //    location = 0;
                //    return location;
                //}
                //else if (userLotChoice == "2")
                //{
                //    location = 1;
                //    return location;
                //}
                //return -1;
            } while (location > places.Count + 1 || location < 1);
            return location-1;
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
                location = LotChoice(CarLot.Lots);
                if (location == 1 || location == 0)
                {
                    do
                    {

                        Console.Clear();

                        CarLot.Lots[location].DisplayMenu();
                        input = GetInteger("Select an ID: ", CarLot.Lots[location]);
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
            } while (location != CarLot.Lots.Count);
            Console.WriteLine("Thank you foor using the car lot shopping app");
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
