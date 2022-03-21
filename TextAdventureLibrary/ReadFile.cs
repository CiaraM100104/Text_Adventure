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
                inputfile = File.OpenText("rooms.txt");

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
                inputfile = File.OpenText("items.txt");

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
                inputfile = File.OpenText("mobs.txt");

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
                inputfile = File.OpenText("potions.txt");

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
                inputfile = File.OpenText("weapons.txt");

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
                inputfile = File.OpenText("treasure.txt");

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
