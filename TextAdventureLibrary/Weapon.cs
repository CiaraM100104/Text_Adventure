using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Weapon : IngameItem
    {
 
        private string _damageType;
        private string _damage;

        public Weapon(string idNumber, string name, string description, string damageType, string price, string damage)
            : base(name, idNumber, price, description)
        {

            _damage = damage;
        }


        public string damageType
        {
            get { return _damageType; }
            set { }
        }


        public string damage
        {
            get { return _damage; }
            set { }
        }

      
    }
}
