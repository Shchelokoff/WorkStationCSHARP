// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите число строк для первого и второго массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов для первого и второго массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int [,]array1=new int [x,y];
int [,]array2=new int [x,y];
int [,]resultArray=new int [x,y];
InitArray(array1);
InitArray(array2);
Console.WriteLine("Ваш первый массив: ");
PrintArray(array1);
Console.WriteLine("Ваш второй массив: ");
PrintArray(array2);
Console.WriteLine("Результат произведения двух массивов: ");
MultiplyArray(array1, array2);
PrintArray(resultArray);

void InitArray(int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
        
void PrintArray(int [,] array)
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

void MultiplyArray(int [,]array1, int [,]array2)
{
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            resultArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
}
