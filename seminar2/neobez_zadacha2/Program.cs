Console.Write("Введите сколько программистов увидит робот: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 100 == 12 || num % 100 == 13 || num % 100 == 14)
{
    Console.Write($"{num} программистов");
}
else
{
    if (num % 10 == 2 || num % 10 == 3 || num % 10 == 4)
    {
        Console.Write($"{num} программиста");
    }
    else
    {
        if (num % 100 == 11)
        {
            Console.Write($"{num} программистов");
        }
        else if (num % 10 == 1)
        {
            Console.Write($"{num} программист");
        }
        else Console.Write($"{num} программистов");
    }
}