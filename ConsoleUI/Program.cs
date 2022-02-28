using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
* 2/27/2022
* CSC 153
* Ciara McLaughlin
* Text based adventure game with only a menu and movement system. Also creates player text file.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                StreamWriter outputFile;

                Console.WriteLine("Enter your name > ");
                string playerName = Console.ReadLine();

                outputFile = File.AppendText("PlayerInfo.txt");

                Console.WriteLine("Enter your class > ");
                string playerClass = Console.ReadLine()
                Console.WriteLine("Enter your weapon > ");
                string playerWeapon = Console.ReadLine();

                outputFile.WriteLine($"{playerName},{playerClass},{playerWeapon}");

                outputFile.Close();

                int roomLocation = 0; 
                bool exit = false;

                StreamReader inputFileItem = File.OpenText("items.txt");
                StreamReader inputFileMob = File.OpenText("Mobs.txt");
                StreamReader inputFilePotion = File.OpenText("potions.txt");
                StreamReader inputFileRoom = File.OpenText("rooms.txt");
                StreamReader inputFileTreasure = File.OpenText("treasure.txt");
                StreamReader inputFileWeapon = File.OpenText("weapons.txt");


                List<string> items = new List<string>();
                List<string> mobs = new List<string>();
                List<string> rooms = new List<string>();
                List<string> weapons = new List<string>();
                List<string> potions = new List<string>();
                List<string> treasures = new List<string>();



                while (exit == false)
                {
                    while (inputFileRoom.EndOfStream == false)
                    {
                        rooms.Add(inputFileRoom.ReadLine());
                    }
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
                    Console.WriteLine(); 

                    
                    switch (input.ToLower())
                    {
                        case "1":
                            while (inputFileRoom.EndOfStream == false)
                            {
                                rooms.Add(inputFileRoom.ReadLine());
                            }
                            foreach (string room in rooms)
                            {
                                Console.Write($"{room} ");
                            }
                            Console.WriteLine();
                            break;
                        case "2":
                            while (inputFileWeapon.EndOfStream == false)
                            {
                                weapons.Add(inputFileWeapon.ReadLine());
                            }
                            foreach (string weapon in weapons)
                            {
                                Console.Write($"{weapon} ");
                                Console.WriteLine();
                            }
                            break;
                        case "3":
                            while (inputFilePotion.EndOfStream == false)
                            {
                                potions.Add(inputFilePotion.ReadLine());
                            }
                            foreach (string potion in potions)
                            {
                                Console.Write($"{potion} ");
                                Console.WriteLine();
                            }
                            break;
                        case "4":
                            while (inputFileTreasure.EndOfStream == false)
                            {
                                treasures.Add(inputFileTreasure.ReadLine());
                            }
                            foreach (string treasure in treasures)
                            {
                                Console.Write($"{treasure} ");
                                Console.WriteLine();
                            }
                            break;
                        case "5":
                            while (inputFileItem.EndOfStream == false)
                            {
                                items.Add(inputFileItem.ReadLine());
                            }
                            foreach (string item in items)
                            {
                                Console.Write($"{item} ");
                                Console.WriteLine();
                            }
                            break;
                        case "6":
                            while (inputFileMob.EndOfStream == false)
                            {
                                mobs.Add(inputFileMob.ReadLine());
                            }
                            foreach (string mob in mobs)
                            {
                                Console.Write($"{mob} ");
                                Console.WriteLine();
                            }
                            break;
                        case "rooms":
                            while (inputFileRoom.EndOfStream == false)
                            {
                                rooms.Add(inputFileRoom.ReadLine());
                            }
                            foreach (string room in rooms)
                            {
                                Console.Write($"{room} ");
                                Console.WriteLine();
                            }
                            break;
                        case "weapons":
                            while (inputFileWeapon.EndOfStream == false)
                            {
                                weapons.Add(inputFileWeapon.ReadLine());
                            }
                            foreach (string weapon in weapons)
                            {
                                Console.Write($"{weapon} ");
                                Console.WriteLine();
                            }
                            break;
                        case "potions":
                            while (inputFilePotion.EndOfStream == false)
                            {
                                potions.Add(inputFilePotion.ReadLine());
                            }
                            foreach (string potion in potions)
                            {
                                Console.Write($"{potion} ");
                                Console.WriteLine();
                            }
                            break;
                        case "treasure":
                            while (inputFileTreasure.EndOfStream == false)
                            {
                                treasures.Add(inputFileTreasure.ReadLine());
                            }
                            foreach (string treasure in treasures)
                            {
                                Console.Write($"{treasure} ");
                                Console.WriteLine();
                            }
                            break;
                        case "items":
                            while (inputFileItem.EndOfStream == false)
                            {
                                items.Add(inputFileItem.ReadLine());
                            }
                            foreach (string item in items)
                            {
                                Console.Write($"{item} ");
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }


        }
    }
    }

