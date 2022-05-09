using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    class Treasure : IngameItem
    {


        private string _questItems;


        public Treasure(string idNumber, string name, string price, string questItems, string description)
            : base(name, idNumber, price, description)
        {
            _questItems = questItems;
        }



        public string questItems
        {
            get { return _questItems; }
            set { }
        }


        public override string ToString()
        {
            return name;
        }
    }
}
