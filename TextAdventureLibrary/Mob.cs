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
        private int _hp;
        private string _ac;
        private string _weapon;
        private string _description;

        public Mob(string idNumber, string name, string race, string mobClass, int hp, string ac, string weapon, string description)
        {
            _name = name;
            _idNumber = idNumber;
            _race = race;
            _class = mobClass;
            _hp = hp;
            _ac = ac;
            _weapon = weapon;
            _description = description;
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

        public int hp
        {
            get { return _hp; }
            set { }
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
