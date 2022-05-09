using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Potion : IngameItem
    {

        private string _valueChange;

        public Potion(string idNumber, string name, string price, string valueChange, string description)
            : base(name, idNumber, price, description)
        {
            _valueChange = valueChange;
 
        }






        public string valueChange
        {
            get { return _valueChange; }
            set { }
        }


        public override string ToString()
        {
            return name;
        }
    

    }
}
