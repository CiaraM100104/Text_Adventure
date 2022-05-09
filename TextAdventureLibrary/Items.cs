using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Items : IngameItem
    {

        private string _questItem;
        private string _required;
 


        public Items(string idNumber, string name, string price, string questItem, string required, string description)
            : base(name, idNumber, price, description)
        {
 
            questItem = _questItem;
            required = _required;
  
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
