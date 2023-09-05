// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
string[] cibiPreferiti = { "gelato", "ciccolato", "patatine", "biscotti", "pizza", "cotolette", "pollo fritto" };

Console.WriteLine($"La classifica è composta da: {cibiPreferiti.Length} cibi");

for(var i = 0; i < cibiPreferiti.Length; i++)
{
    Console.Write(cibiPreferiti[i]);
    Console.WriteLine(" " + i);
}

Console.Write("Top cibo: ");
Console.WriteLine(cibiPreferiti[0]);
Console.Write("Cibo preferito ma non troppo: ");
Console.WriteLine(cibiPreferiti[6]);
