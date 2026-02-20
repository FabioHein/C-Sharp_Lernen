using Mygame.Enums;
using Mygame.Interfaces;
using System;

namespace Mygame.Items
{
    public class HealPotion : Item, IUseable
    {

        public HealPotion(string name, int gold) : base(name, ItemType.Potion, gold)
        {
        }



        public void Use()
        {
            Console.WriteLine($"Benutze {_name} (Type : {_type})");
        }
    }
}