﻿// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} - чётное.");
}
else
{
    Console.WriteLine($"Число {a} - нечётное.");
}