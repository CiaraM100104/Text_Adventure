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


            try
            {
                
                StreamWriter outputFile;

                Console.WriteLine("Enter your name > ");
                string playerName = Console.ReadLine();
                
                outputFile = File.AppendText("PlayerInfo.txt");

                Console.WriteLine("Enter your race > ");
                string playerRace = Console.ReadLine();
                Console.WriteLine("Enter your class (Gunner, Exorcist, Priest) > ");
                string playerClass = Console.ReadLine();
                Console.WriteLine("Enter your password (Must contain a capital, lowercase and special character) > ");
                string playerPassword = Console.ReadLine();
                bool valid = false;
                while (!valid)
                {
                    valid = Player.checkPassword(ref playerPassword);
                    if (valid == false)
                    {
                        Console.WriteLine("Enter your password (Must contain a capital, lowercase and special character) > ");
                        playerPassword = Console.ReadLine();
                    }
                    else
                    {
                        valid = true;
                        Console.WriteLine("Enjoy the game! If you need help just type in 'h'.");
                    }
                }
                Player currentPlayer = new Player(playerName, playerPassword, playerRace, playerClass);
                outputFile.WriteLine($"{currentPlayer}");

                outputFile.Close();

                int roomLocation = 0;
                bool exit = false;

                List<Items> inventoryList = new List<Items>();


                List<string> items = ReadFile.ItemsFileReader();
                List<string> mobs = ReadFile.MobsFileReader();
                List<string> rooms = ReadFile.RoomFileReader();
                List<string> weapons = ReadFile.WeaponsFileReader();
                List<string> potions = ReadFile.PotionsFileReader();
                List<string> treasures = ReadFile.TreasureFileReader();

                List<Room> playerRooms = new List<Room>();
                List<Items> gameItems = new List<Items>();
                List<Mob> gameMobs = new List<Mob>(); 


                foreach (string room in rooms)
                {
                    string[] tokens = room.Split(',');
                    Room playerRoom = new Room(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4]); 
                    playerRooms.Add(playerRoom);
                }

                foreach (string mob in mobs)
                {
                    string[] tokens = mob.Split(',');
                    Mob gameMob = new Mob(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7]);
                    gameMobs.Add(gameMob);
                }

                foreach (string item in items)
                {
                    string[] tokens = item.Split(',');
                    Items gameItem = new Items(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);
                    gameItems.Add(gameItem);
                }


                while (exit == false)
                {
                    Console.WriteLine(playerRooms[roomLocation]);
                    Console.WriteLine(gameMobs[roomLocation]);
                    Console.WriteLine("Enter a choice > ");
                    string input = Console.ReadLine();
                    Console.WriteLine(); 

                    
                    switch (input.ToLower())
                    {
                        case "h":

                            Console.WriteLine("Press the numbers beside the correlating actions to do them ");
                            Console.WriteLine("1. Move North ");
                            Console.WriteLine("2. Move South ");
                            Console.WriteLine("3. Move East");
                            Console.WriteLine("4. Move West");
                            Console.WriteLine("5. Display All information within the game");
                            Console.WriteLine("6. Display Inventory");
                            Console.WriteLine("7. Pick up item");
                            Console.WriteLine("8. Attack enemy");
                            Console.WriteLine("9. Exit");
                            break;
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
                                Console.WriteLine("The enemies health is now " + newHealth);
                            }
                            else if (newHealth <= 0)
                            {
                                Console.WriteLine("The enemy is now dead. You decide to move on to the next one.");
                                newHealth = 50;
                            }
                            else
                            {
                                newHealth = GameSystems.DecreasingHealth(ref newHealth);
                                Console.WriteLine("The enemies health is now " + newHealth);
                            }
                            break;
                        case "4":
                            exit = true;
                            break;
                        case "5":
                            roomLocation = GameSystems.TravelingSystemEast(ref roomLocation, playerRooms);
                            Console.WriteLine(roomLocation);
                            if (roomLocation > 3)
                            {
                                Console.WriteLine("You can not go East!");
                                Console.WriteLine();
                            }

                            break;
                        case "6":
                            roomLocation = GameSystems.TravelingSystemWest(ref roomLocation);
                            Console.WriteLine(roomLocation);
                            if (roomLocation < 0)
                            {
                                Console.WriteLine("You can not go West!");
                                Console.WriteLine();
                            }
                            break;
                        case "7":
                            if (roomLocation == 1 || roomLocation == 4 || roomLocation == 5)
                            {
                                Console.WriteLine("None of these items are of use to you.");
                            }
                            else if (roomLocation == 2)
                            {
                                

                            }
                            else
                            {

                            }
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

