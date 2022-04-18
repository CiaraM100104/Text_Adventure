using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventureLibrary
{
    public static class ReadFile
    {
        public static List<string> RoomFileReader()
        {

            List<string> returnList = new List<string>();
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\snowt\source\repos\TextAdventure\ConsoleUI\Rooms1.csv");

                while (inputfile.EndOfStream == false)
                {
                    returnList.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return returnList;
        }

        public static List<string> ItemsFileReader()
        {
            List<string> returnList = new List<string>();
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\snowt\source\repos\TextAdventure\ConsoleUI\items.csv");

                while (inputfile.EndOfStream == false)
                {
                    returnList.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return returnList;
        }

        public static List<string> MobsFileReader()
        {
            List<string> returnList = new List<string>();
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\snowt\source\repos\TextAdventure\ConsoleUI\Mobs.csv");

                while (inputfile.EndOfStream == false)
                {
                    returnList.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return returnList;
        }

        public static List<string> PotionsFileReader()
        {
            List<string> returnList = new List<string>();
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\snowt\source\repos\TextAdventure\ConsoleUI\potions.csv");

                while (inputfile.EndOfStream == false)
                {
                    returnList.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return returnList;
        }

        public static List<string> WeaponsFileReader()
        {
            List<string> returnList = new List<string>();
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\snowt\source\repos\TextAdventure\ConsoleUI\weapons.csv");

                while (inputfile.EndOfStream == false)
                {
                    returnList.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return returnList;
        }

        public static List<string> TreasureFileReader()
        {
            List<string> returnList = new List<string>();
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\snowt\source\repos\TextAdventure\ConsoleUI\treasure.csv");

                while (inputfile.EndOfStream == false)
                {
                    returnList.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return returnList;
        }


    }
}
