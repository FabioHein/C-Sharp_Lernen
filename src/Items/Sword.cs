using Mygame.Enums;
using Mygame.Interfaces;
using System;

namespace Mygame.Items
{
    public class Sword : Item, IEquipable, IUseable
    {
       
        public Sword(string name) : base(name, ItemType.Weapon)
        { 
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