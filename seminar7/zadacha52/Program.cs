//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите число строк вашего массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов вашего массива: ");
int y = Convert.ToInt32(Console.ReadLine());
decimal [,]array=new decimal [x,y];
InitArray(array);
PrintArray(array);
Arifmetika(array);

void InitArray(decimal [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 101);
        }
    }
}
        
void PrintArray(decimal [,] array)
{
Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} \t");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}

void Arifmetika(decimal [,]array)
{
decimal [] avgNumbers = new decimal [array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    decimal  result = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    avgNumbers[i] = result / array.GetLength(0);
    avgNumbers[i] = Math.Round(avgNumbers[i], 2);
}
Console.Write("Среднее арифметическое элементов в каждом столбце: ");
foreach(decimal element in avgNumbers) Console.Write($" {element}");
}

