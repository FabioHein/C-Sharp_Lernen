using Mygame.Enums;
using Mygame.Interfaces;
using System;

namespace Mygame.Items
{
    public class HealPotion : IUseable
    {
        private string _name;
        private ItemType _type;

        public HealPotion(string name)
        {
            _name = name;
            _type = ItemType.Potion;
        }



        public void Use()
        {
            Console.WriteLine($"Spieler benutzt {_name}.");
        }
    }
}