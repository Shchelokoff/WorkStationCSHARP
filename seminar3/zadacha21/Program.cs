// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Otrezok (int x1, int y1, int z1, int x2, int y2, int z2) 
{
    int x = x2-x1;
    int y = y2-y1;
    int z = z2-z1;
    int res = Convert.ToInt32(Math.Sqrt(x*x+y*y+z*z));
    return res;
}

Console.Write ("Введите координату x1 точки A ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y1 точки A ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z1 точки A ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату x2 точки B ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y2 точки B ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z2 точки B ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Расстояние между точками A и B в 3D пространстве составляет {Otrezok (x1, y1, z1, x2, y2, z2)}");
