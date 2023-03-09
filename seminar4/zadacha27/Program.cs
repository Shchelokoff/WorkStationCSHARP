// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa(int a)
{
    int c = 0;
    for (int i = 0; a > 0; i++)
    {
        int b = a % 10;
        a = a / 10;
        c = c + b;
    }
    return c;
}

Console.Write("Введите целое неотрицательное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в вашем числе: {Summa(a)}");