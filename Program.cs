using Mygame.Enums;
using Mygame.Interfaces;
using Mygame.Items;
using System;
using System.ComponentModel;
using System.Collections.Generic;


int sumGold = 0;
List<Item> inventar = new List<Item>();

inventar.Add(new Sword("Excalibur", 25));
inventar.Add(new HealPotion("Heiltrank", 5));

foreach (var item in inventar)
{
    if (item is IEquipable e) e.Equip();
    if (item is IUseable u) u.Use();
}

foreach(var item in inventar)
{
    sumGold += item.GoldValue;
}

Console.WriteLine($"--- Inventar - Bericht ---");
Console.WriteLine($"Anzahl der Gegenstände: {inventar.Count}");
Console.WriteLine($"Gesamtwert des Inventar: {sumGold}");

Console.WriteLine("Programm erfolgreich Beendet.");
Console.ReadKey();