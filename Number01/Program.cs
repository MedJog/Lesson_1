// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Большее число {a}, меньшее число {b}.");
}
else
{
    Console.WriteLine($"Большее число {b}, меньшее число {a}.");
}
