using Mygame.Enums;
using Mygame.Interfaces;
using Mygame.Items;
using System;
using System.ComponentModel;
using System.Collections.Generic;

List<Item> inventar = new List<Item>();

inventar.Add(new Sword("Excalibur"));
inventar.Add(new HealPotion("Heiltrank"));

foreach (var item in inventar)
{
    if (item is IEquipable e) e.Equip();
    if (item is IUseable u) u.Use();
}

Console.WriteLine("Programm erfolgreich Beendet.");
Console.ReadKey();