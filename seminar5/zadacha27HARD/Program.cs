// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

decimal CountOfNumbers(decimal x)
{
    decimal count1 = 1;
    decimal count2 = 0;
    decimal a = x;
    decimal b = x;
    while ((a /= 10) >= 1) count1++;
    while ((b % 1) != 0)
    {
        count2++;
        b *= 10;
    }
    return count1 + count2;
}

Console.WriteLine("Введите целое или дробное число: ");
decimal num = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(CountOfNumbers(num));

