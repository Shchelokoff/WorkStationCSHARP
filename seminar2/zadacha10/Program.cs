﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое неотрицательное трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = (num / 10) % 10;
Console.Write($"Вторая цифра вашего числа это: {num}");