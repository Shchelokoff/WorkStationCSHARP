// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InitArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-1000, 1000);
}
		
void PrintArray(int[] array)
{
    foreach (int element in array) Console.Write($"{element} ");
    Console.WriteLine();
}

int PoiskSummNeChet(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) summ = summ + array[i];
    }
    return summ;
}
int[] array = new int[4];
InitArray(array);
PrintArray(array);
Console.WriteLine($"Сумма чисел стоящих в массиве на нечётных позициях: {PoiskSummNeChet(array)}");

