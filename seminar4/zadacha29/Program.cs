// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Massive(int n)
{
    int[] arr = new int[n];
    int z = 0;
    for (int i = 0; i < n; i++)
    {
        Random rnd = new Random();
        arr[z] = rnd.Next(0, 9);
        z++;
    }
Console.WriteLine($"[{String.Join(",", arr)}]");
}

Massive(8);