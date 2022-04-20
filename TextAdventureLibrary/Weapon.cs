using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Weapon
    {
        private string _idNumber;
        private string _name;
        private string _description;
        private string _damageType;
        private string _price;
        private string _damage;

        public Weapon(string idNumber, string name, string description, string damageType, string price, string damage)
        {
            _name = name;
            _idNumber = idNumber;
            _description = description;
            _damageType = damageType;
            _price = price;
            _damage = damage;
        }

        public string idNumber
        {
            get { return _idNumber; }
            set { }
        }

        public string name
        {
            get { return _name; }
            set { }
        }

        public string description
        {
            get { return _description; }
            set { }
        }

        public string damageType
        {
            get { return _damageType; }
            set { }
        }

        public string price
        {
            get { return _price; }
            set { }
        }

        public string damage
        {
            get { return _damage; }
            set { }
        }

      
    }
}
