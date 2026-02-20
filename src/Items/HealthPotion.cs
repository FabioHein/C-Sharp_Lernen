using Mygame.Enums;
using Mygame.Interfaces;
using System;

namespace Mygame.Items
{
    public class HealPotion : Item, IUseable
    {

        public HealPotion(string name)
        {
            _name = name;
            _type = ItemType.Potion;
        }



        public void Use()
        {
            Console.WriteLine($"Benutze {_name} (Type : {_type})");
        }
    }
}