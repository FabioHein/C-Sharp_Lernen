using System;
using Mygame.Enums;


namespace Mygame.Items
{

    public abstract class Item
    {
        protected string _name;
        protected ItemType _type;

        public Item(string name, ItemType type)
        {
            _name = name;
            _type = type;
        }
    }
}