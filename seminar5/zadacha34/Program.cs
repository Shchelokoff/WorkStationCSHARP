// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void InitArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int element in array) Console.Write($"{element} ");
    Console.WriteLine();
}

int PoiskChet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
int[] array = new int[4];
InitArray(array);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {PoiskChet(array)}");
