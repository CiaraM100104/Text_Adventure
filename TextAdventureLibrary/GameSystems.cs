using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public static class GameSystems
    {
        public static int TravelingSystemNorth(ref int roomLocation)
        {
            if (roomLocation != 4)
            {
                roomLocation++;
            }

            return roomLocation;
        }

        public static int TravelingSystemSouth(ref int roomLocation)
        {
            if (roomLocation != 0)
            {
                roomLocation--;
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

        }

    }
}
