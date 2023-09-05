// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
string[] cibiPreferiti = { "gelato", "ciccolato", "patatine", "biscotti", "pizza", "cotolette", "pollo fritto", "pasta", "o", "w", "a", "p"};

Console.WriteLine($"La classifica è composta da: {cibiPreferiti.Length} cibi");

for(var i = 0; i < cibiPreferiti.Length; i++)
{
    Console.Write(cibiPreferiti[i]);
    Console.WriteLine(" " + i);
}

Console.Write("Top cibo: ");
Console.WriteLine(cibiPreferiti[0]);
Console.Write("Cibo preferito ma non troppo: ");
Console.WriteLine(cibiPreferiti[cibiPreferiti.Length-1]);


double ciboMediano = cibiPreferiti.Length / 2;

if(cibiPreferiti.Length % 2 == 0)
{
    Console.Write($"Il cibo mediano è:  {cibiPreferiti[(int)ciboMediano-1]} e {cibiPreferiti[(int)ciboMediano]}");
}else
{
    Console.Write($"Il cibo mediano è:  {cibiPreferiti[(int)ciboMediano]}");
}

