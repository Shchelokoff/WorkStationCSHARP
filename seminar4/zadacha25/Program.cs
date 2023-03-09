// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int InStepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write("Введите число, которое будут возводить в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое будет являться степенью первого числа: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число в степени второго будет {InStepen(a, b)}");