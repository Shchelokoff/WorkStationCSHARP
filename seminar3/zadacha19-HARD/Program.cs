// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

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

