using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Potion
    {
        private int _idNumber = 101;
        private string _name;
        private string _price;
        private string _valueChange;
        private string _description;

        public Potion(int idNumber, string name, string price, string valueChange, string description)
        {
            _name = name;
            _idNumber = idNumber;
            _description = description;
            _valueChange = valueChange;
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

        public string valueChange
        {
            get { return _valueChange; }
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
