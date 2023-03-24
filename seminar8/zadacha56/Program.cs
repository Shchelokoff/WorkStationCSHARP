// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет      
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей    
 // суммой элементов: 1 строка
Console.WriteLine("Введите число строк вашего массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов вашего массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int [,]array=new int [x,y];
int [] summRowArray = new int [array.GetLength(1)];
InitArray(array);
PrintArray(array);
SummElemRowArray(array);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {SearchMinRow(summRowArray)}");

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

void SummElemRowArray(int [,]array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    int  result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
    summRowArray[i] = result;
}
}

int SearchMinRow(int [] summRowArray)
{
int  min = summRowArray[0];
int index = 0;
for (int m = 1; m < summRowArray.Length; m++)
{
    if(min>summRowArray[m])
    {
        min=summRowArray[m];
        index = m;
    }
}
return index+1;
}
