﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число для проверки на чётность: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
{
    Console.Write($"Введённое число является чётным");
}
else
{
    Console.Write($"Введённое число является нечётным");
}
