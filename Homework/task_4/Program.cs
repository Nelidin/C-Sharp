﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//                                           2, 3, 7 -> 7
//                                           44 5 78 -> 78
//                                           22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"max = {max}");