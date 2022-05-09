using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public abstract class IngameItem
    {
        private string _price;
        private string _idNumber;
        private string _name;
        private string _description;

        public IngameItem(string name, string idNumber, string price, string description)
        {

        }

        public string name
        {
            get { return _name; }
            set { }
        }

        public string idNumber
        {
            get { return _idNumber; }
            set { }
        }

        public string price
        {
            get { return _price; }
            set { }
        }

        public string description
        {
            get { return _description; }
            set { }
        }
    }
}
