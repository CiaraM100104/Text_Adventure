using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    abstract public class LivingCreatures
    {
        private string _race;
        private string _class;
        private string _ac;
        private int _hp;
        private string _name;

        public LivingCreatures(string race, string creatureClass, string ac, string name, int hp)
        {

        }

        public string race
        {
            get { return _race; }
            set { }
        }

        public string name
        {
            get { return _name; }
            set { }
        }

        public string creatureClass
        {
            get { return _class; }
            set { }
        }

        public int hp
        {
            get { return _hp; }
            set { }
        }
    }
}
