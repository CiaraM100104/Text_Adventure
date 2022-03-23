using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TextAdventureLibrary;
/**
* 3/20/2022
* CSC 153
* Ciara McLaughlin
* Text based adventure game with only a menu and movement system. Also creates player text file, now incorporates combat
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int defaultHealth = 50;
            int newHealth = 50;
            int damageDone = 0;


            try
            {
                
                StreamWriter outputFile;

                Console.WriteLine("Enter your name > ");
                string playerName = Console.ReadLine();

                outputFile = File.AppendText("PlayerInfo.txt");

                Console.WriteLine("Enter your class > ");
                string playerClass = Console.ReadLine();
                Console.WriteLine("Enter your weapon > ");
                string playerWeapon = Console.ReadLine();

                outputFile.WriteLine($"{playerName},{playerClass},{playerWeapon}");

                outputFile.Close();

                int roomLocation = 0; 
                bool exit = false;


                List<string> items = ReadFile.ItemsFileReader();
                List<string> mobs = ReadFile.MobsFileReader();
                List<string> rooms = ReadFile.RoomFileReader();
                List<string> weapons = ReadFile.WeaponsFileReader();
                List<string> potions = ReadFile.PotionsFileReader();
                List<string> treasures = ReadFile.TreasureFileReader();


    
                while (exit == false)
                {
  
                    Console.WriteLine($"You are in - {rooms[roomLocation]} "); 
                    Console.WriteLine("1. Move North ");
                    Console.WriteLine("2. Move South ");
                    Console.WriteLine("3. Attack");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter a choice > ");
                    string input = Console.ReadLine();
                    Console.WriteLine(); 

                    
                    switch (input.ToLower())
                    {
                        case "1":
                            roomLocation = GameSystems.TravelingSystemNorth(ref roomLocation);
                            if (roomLocation == 4)
                            {
                                Console.WriteLine("You can not go north!");
                                Console.WriteLine();
                            }
                            Console.WriteLine(); 
                            break;
                        case "2":

                            roomLocation = GameSystems.TravelingSystemSouth(ref roomLocation);
                            if (roomLocation == 0)
                            {
                                Console.WriteLine("You can not go south!");
                                Console.WriteLine();
                            }
                            break;
                        case "3":

                            if (newHealth == 50)
                            {
                                newHealth = GameSystems.DecreasingHealth(ref defaultHealth);
                                damageDone = GameSystems.HealthSubtraction(ref damageDone);
                                Console.WriteLine("The enemies health is now " + newHealth + " You did " + damageDone + " making the damage total " + (50 - newHealth));
                            }
                            else if (newHealth <= 0)
                            {
                                Console.WriteLine("The enemy is now dead. You decide to move on to the next one.");
                                newHealth = 50;
                            }
                            else
                            {
                                damageDone = GameSystems.HealthSubtraction(ref damageDone); 
                                newHealth = GameSystems.DecreasingHealth(ref newHealth);
                                Console.WriteLine("The enemies health is now " + newHealth + " You did " + damageDone + " making the damage total " + (50 - newHealth));
                            }
                            break;
                        case "4":
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

