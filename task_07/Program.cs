﻿// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    int lastNumber = num % 10;
    Console.Write($"Последняя цифра числа {num} = {lastNumber}");
}
else
{
    Console.Write("Error!");
}