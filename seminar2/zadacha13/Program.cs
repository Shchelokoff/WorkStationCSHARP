﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое неотрицательное третьей и выше разрядности число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100)
{
    while (num >= 9999)
    {
        num = num / 10;
    }
    num = (num / 10) % 10;
    Console.Write($"Третья цифра вашего числа это: {num}");
}
else Console.Write($"Вы ввели не трёхзначное число!");