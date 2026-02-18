using Mygame.Enums;
using Mygame.Interfaces;
using Mygame.Items;
using System;

var healthpotion = new HealPotion("Kleiner Heiltrank");
var sword = new Sword("Rostiges Schwert");


sword.Equip();
sword.Use();
sword.Unequip();
healthpotion.Use();

Console.WriteLine("Programm erfolgreich Beendet.");