﻿Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.Now;

Console.WriteLine("--------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. It is great that you are working on improving yourself\n");
Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Substraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("--------------------------");

var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("Addition game selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("Substraction game selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("Multiplecation game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid input");
}