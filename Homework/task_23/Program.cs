﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//                                         3 -> 1, 8, 27
//                                         5 -> 1, 8, 27, 64, 125


Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 1;

while (count <= num)

{
    Console.Write($"{count * count * count}, ");
    count++;
}
