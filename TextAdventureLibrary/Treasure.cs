using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    class Treasure
    {
        private int _idNumber = 101;
        private string _name;
        private string _price;
        private string _questItems;
        private string _description;

        public Treasure(int idNumber, string name, string price, string questItems, string description)
        {
            _name = name;
            _idNumber = idNumber;
            _description = description;
            _questItems = questItems;
            _price = price;
        }

        public int idNumber
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

        public string questItems
        {
            get { return _questItems; }
            set { }
        }

        public string price
        {
            get { return _price; }
            set { }
        }



        public override string ToString()
        {
            return name;
        }
    }
}
