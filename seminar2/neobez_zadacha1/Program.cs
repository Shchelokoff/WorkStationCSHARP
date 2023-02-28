for (int i=1; i<101; i++)
{
    if (i%3==0 && i%5==0 && i%15==0)
    {
        string j = "FizzBuzz";
        Console.Write($"{j} ");
    }
    else 
    {
        if (i%3==0)
        {
        string j = "Fizz";
        Console.Write($"{j} ");
        }
        else if (i%5==0)
        {
        string j = "Buzz";
        Console.Write($"{j} ");
        }
        else Console.Write($"{i} ");
    }
}
