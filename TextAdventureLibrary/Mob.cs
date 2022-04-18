using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Mob
    {
        private string _idNumber;
        private string _name;
        private string _race;
        private string _class;
        private string _hp;
        private string _ac;
        private string _weapon;
        private string _description;

        public Mob(string idNumber, string name, string race, string mobClass, string hp, string ac, string weapon, string description)
        {
            _name = name;
            idNumber = _idNumber;
            race = _race;
            mobClass = _class;
            hp = _hp;
            ac = _ac;
            _weapon = weapon;
            description = _description;
        }

        public string idNumber
        {
            get { return _idNumber; }
        }

        public string name
        {
            get { return _name; }
        }

        public string race
        {
            get { return _race; }
        }

        public string mobClass
        {
            get { return _class; }
        }

        public string hp
        {
            get { return _hp; }
        }

        public string ac
        {
            get { return _ac; }
        }

        public string weapon
        {
            get { return _weapon; }
        }

        public string description
        {
            get { return _description; }
        }

        public override string ToString()
        {
            return "There is an " + name + " in the room, and they wield " + weapon;
        }

    }




}
