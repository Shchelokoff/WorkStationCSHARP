//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном 
//массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите число строк вашего массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов вашего массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше число для поиска в вашем массиве: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,]array=new int[x,y];
InitArray(array);
PrintArray(array);
Poisk(z);
PoiskOtsutstvya(z);

void InitArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
        
void PrintArray(int[,] array)
{
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

void Poisk(int z)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]==z) Console.WriteLine($"Ваше число находится в {i} строке, в {j} столбце");
        }
        }
    }

void PoiskOtsutstvya(int z)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]!=z && i==array.GetLength(0)-1 && j==array.GetLength(1-1)) Console.WriteLine($"Вашего числа нет в массиве");
        }
    }
}
