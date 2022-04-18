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
        }

        public string name
        {
            get { return _name; }
        }

        public string description
        {
            get { return _description; }
        }

        public string price
        {
            get { return _price; }
        }

        public string questItem
        {
            get { return _questItem; }
        }

        public string required
        {
            get { return _required; }
        }




    }
}
