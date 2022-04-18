using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public static class GameSystems
    {

        const int MAP_WIDTH = 3;
        public static int TravelingSystemNorth(ref int roomLocation)
        {
            if (roomLocation != (MAP_WIDTH - 1) && roomLocation != (MAP_WIDTH * 2) - 1 && roomLocation != (MAP_WIDTH * 3) - 1)
            {
                roomLocation++;
            }

            return roomLocation;
        }

        public static int TravelingSystemSouth(ref int roomLocation)
        {
            if (roomLocation != 0 && roomLocation != MAP_WIDTH && roomLocation != MAP_WIDTH * 2)
            {
                roomLocation--;
            }

            return roomLocation;
        }

        public static int TravelingSystemEast(ref int roomLocation, List<Room> roomList)
        {
            if (roomLocation + MAP_WIDTH <= roomList.Count - 1)
            {
                roomLocation += MAP_WIDTH;
            }
            return roomLocation;
        }

        public static int TravelingSystemWest(ref int roomLocation)
        {
            if (roomLocation - MAP_WIDTH >= 0)
            {
                roomLocation -= MAP_WIDTH;
            }
            return roomLocation;
        }

        public static int DecreasingHealth(ref int health)
        {
            HealthSubtraction(ref health);
            return health;

        }



        public static void HealthSubtraction(ref int enemyHealth)
        {
            int healthDeduction = 0;
            Random rand = new Random();
            healthDeduction = rand.Next(1, 21);

            enemyHealth = enemyHealth - healthDeduction;
            return healthDeduction;

        }





    }
}
