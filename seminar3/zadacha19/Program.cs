// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int num)
{
int num1 = num;
int res = 0;
while(num > 0)
{
    res *= 10;
    int num2 = num % 10;
    res += num2;
    num /= 10;
}
if (num1==res) 
{
    Console.WriteLine($"число {num1} - это палиндром");
}
else Console.WriteLine($"число {num1} - это не палиндром");
}

Console.Write("Введите целое положительное 5-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);