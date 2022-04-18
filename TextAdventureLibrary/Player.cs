using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventureLibrary
{
    public class Player
    {
        private int _idNumber = 101;
        private string _name;
        private string _password;
        private string _race;
        private string _class;
        private string _ac;
        private int _location = 0;
        private List<Items> inventory;
        private List<Items> quests;

        public Player(string name, string password, string race, string playerclass)
        {
            password = _password;
            name = _name;
            race = _race;
            playerclass = _class;

        }

        public static bool checkPassword(ref string password)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(password) && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[a-z]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
