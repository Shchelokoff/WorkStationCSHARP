// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

int Otrezok(int num)
{
    int a = num * 2;
    int[] arr = new int[a];
    int z = 0;
    int e = 0;
    int b = 0;
    int g = num;
    int q = num;
    for (int i = 0; i < a; i++)
    {
        Console.Write("Введите последовательно координаты двух точек: ");
        arr[z] = int.Parse(Console.ReadLine());
        z++;
    }
    for (int i = 0; i < q; i++)
    {
        arr[e] = arr[e] - arr[g];
        e++;
        g++;
    }
    for (int i = 0; i < a; i++)
    {
        arr[b] = Convert.ToInt32(Math.Pow(arr[b], 2));
        b++;
    }
    int preResult = arr.Sum();
    int result = Convert.ToInt32(Math.Sqrt(preResult));
    return result;
}
Console.Write("Введите размерность вашего пространства ввиде целого неотрицателтного числа: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние между двумя точками в вашем N-мерном постранстве составляет: {Otrezok(num)}");
