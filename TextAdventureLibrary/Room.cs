using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Room
    {
        private string _idNumber;
        private string _name;
        private string _description;
        private string _exits;
        private string _itemsList;
        public List<Items> inventory;
        private List<Weapon> weapons;

        public Room(string idNumber, string name, string description, string exits, string itemsList)
        {
            _idNumber = idNumber;
            _name = name;
            _description = description;
            _exits = exits;
            _itemsList = itemsList;
            inventory = new List<Items>();

        }

        public static void addItem(Items itemToAdd, List<Items> playerInventory)
        {
            playerInventory.Add(itemToAdd);
        }

        public static void addWeapon(Weapon weaponToAdd, List<Weapon> playerInventory)
        {
            playerInventory.Add(weaponToAdd);
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

        public string exits
        {
            get { return _exits; }
            set { }
        }

        public string itemsList
        {
            get { return _itemsList; }
            set { }
        }

        public override string ToString()
        {
            return "You are in " + name + " and there is an " + itemsList + " in the room, the current exits are " + exits;
        }
    }
}
