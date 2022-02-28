using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 2/13/2022
* CSC 153
* Ciara McLaughlin
* Text based adventure game with only a menu and movement system.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            int roomLocation = 0;

            //Arrays
            string[] rooms = new string[5] { "Entrance", "Hallway", "Bedroom", "Living Room", "Backyard" };
            string[] weapons = new string[4] { "Ghost Blaster", "Crucifix", "Incense Stick", "Salt Shotgun" };
            string[] potion = new string[2] { "Holy Water", "Herbal Brew" };
            string[] treasure = new string[3] { "Ancient Relic", "Purified Armor", "Ancient Ambulet" };
            //Lists

            List<string> items = new List<string>() { "Prayer beads", "Religious Text", "Holy Statue", "Rosemary" };
            List<string> mobs = new List<string>() { "Lower Ghost", "Stronger Ghost", "Poltergeist ", "Yokai", "Banshee" };

            while (exit == false)
            {
                Console.WriteLine($"You are in - {rooms[roomLocation]} ");
                Console.WriteLine("1. Display Rooms ");
                Console.WriteLine("2. Display Weapon ");
                Console.WriteLine("3. Display Potion");
                Console.WriteLine("4. Display Treasure ");
                Console.WriteLine("5. Display Items ");
                Console.WriteLine("6. Display Mobs ");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter a choice > ");
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        foreach (string value in rooms)
                        {
                            Console.WriteLine(value);
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        {
                            Array.Sort(weapons);

                            Array.ForEach<string>(weapons, s => Console.WriteLine(s));
                        }
                        break;
                    case "3":
                        foreach (string value in potion)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                        foreach (string value in treasure)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "5":
                        foreach (string value in items)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "6":
                        foreach (string value in mobs)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "rooms":
                        foreach (string value in rooms)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "weapons":
                        foreach (string value in weapons)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "potions":
                        foreach (string value in potion)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "treasure":
                        foreach (string value in treasure)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "items":
                        foreach (string value in items)
                        {
                            Console.WriteLine(value);
                            Console.WriteLine();
                        }
                        break;
                    case "n":
                        if (roomLocation != 4)
                        {
                            roomLocation++;
                        }
                        else
                        {
                            Console.WriteLine("You can not go north!");
                            Console.WriteLine();
                        }
                        break;
                    case "s":
                        if (roomLocation != 0)
                        {
                            roomLocation--;
                        }
                        else
                        {
                            Console.WriteLine("You can not go south!");
                            Console.WriteLine();
                        }
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Not a choice.");
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
