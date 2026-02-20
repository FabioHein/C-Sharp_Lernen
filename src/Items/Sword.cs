using Mygame.Enums;
using Mygame.Interfaces;
using System;

namespace Mygame.Items
{
    public class Sword : Item, IEquipable, IUseable
    {
       
        public Sword(string name, int gold) : base(name, ItemType.Weapon, gold)
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