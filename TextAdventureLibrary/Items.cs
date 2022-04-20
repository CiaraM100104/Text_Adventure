using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Items
    {
        private string _idNumber;
        private string _name;
        private string _price;
        private string _questItem;
        private string _required;
        private string _description;


        public Items(string idNumber, string name, string price, string questItem, string required, string description)
        {
            name = _name;
            idNumber = _idNumber;
            price = _price;
            questItem = _questItem;
            required = _required;
            description = _description;
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

        public string price
        {
            get { return _price; }
            set { }
        }

        public string questItem
        {
            get { return _questItem; }
            set { }
        }

        public string required
        {
            get { return _required; }
            set { }
        }

        public override string ToString()
        {
            return "You've picked up " + name;
        }


    }
}
