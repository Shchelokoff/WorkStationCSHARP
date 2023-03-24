// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.               
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого     
//  элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите размерность x для массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность y для массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность z для массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int [,,]array=new int [x,y,z];
InitArray(array);
Console.WriteLine("Ваш трёхмерный массив: ");
PrintArray(array);

void InitArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    int index = 0; 
    for (int x = 0; x < array.GetLength(0); x++)
        {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[index];
                index ++;
            }
        }
    }
}
        
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($"{array[i, j, m]}({i},{j},{m}) ");
            }
        }
    }
}
