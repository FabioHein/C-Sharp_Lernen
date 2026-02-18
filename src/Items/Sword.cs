using Mygame.Enums;
using Mygame.Interfaces;
using System;

namespace Mygame.Items
{
    public class Sword : IEquipable, IUseable
    {
        private string _name;
        private ItemType _type;

        public Sword(string name)
        {
            _name = name;
            _type = ItemType.Weapon;
        }

        public void Equip()
        {
            Console.WriteLine($"Rüste {_name} aus.");
        }

        public void Unequip()
        {
            Console.WriteLine($"Lege {_name} ab.");
        }

        public void Use()
        {
            Console.WriteLine($"Spezial attacke von {_name} wurde ausgelöst.");
        }
    }
}