// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InitArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void PrintArray(int[] array)
{
    foreach (int element in array) Console.Write($"{element} ");
    Console.WriteLine();
}

int DiffMaxAndMin(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max) max = array[j];
    }
    Console.WriteLine(min);
    Console.WriteLine(max);
    int res = max - min;
    return res;
}

int[] array = new int[5];
InitArray(array);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным значением массива: {DiffMaxAndMin(array)}");
