using System;

public abstract class Item
{
    protected string _name;
    protected ItemType _type;

    public Item(string name)
    {
        _name = name;

    }
}
