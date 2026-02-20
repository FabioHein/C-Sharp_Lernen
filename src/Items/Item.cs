using System;
using Mygame.Enums;


namespace Mygame.Items
{

    public abstract class Item
    {
        protected string _name;
        protected ItemType _type;
        public int GoldValue { get;  protected set; }

        public Item(string name, ItemType type, int value)
        {
            _name = name;
            _type = type;
            GoldValue = value;
        }
    }
}