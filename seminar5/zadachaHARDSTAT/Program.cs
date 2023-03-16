// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

void InitArray(int[] array) 
{
for (int i=0; i<array.Length; i++)
    array[i]=new Random().Next(1, 101);
}
        
void PrintArray(int[] array) 
{
foreach(int element in array) Console.Write($"{element} ");
    Console.WriteLine();
}

void Arifmetika(int[] array)
{
int max = array[0];
int min = array[0];
int indexMax = 0;
int indexMin = 0;
int sredneArifm;
int summ = 0;
double median = 0; 
int middleIndex = array.Length/2; 
int[] array1 = new int[5];
for (int i=1; i<array.Length; i++)
{
    if (array[i]>max) 
    {
    max = array[i];
    indexMax = i;
    }
}
for (int j=1; j<array.Length; j++)
{
    if (array[j]<min) 
    {
    min = array[j];
    indexMin = j;
    }
}
for (int m=0; m<array.Length; m++) summ=summ+array[m];
sredneArifm = Convert.ToInt32(summ/array.Length);
array1[0] = max;
array1[1] = indexMax;
array1[2] = min;
array1[3] = indexMin;
array1[4] = sredneArifm;
foreach(int element in array1) Console.Write($"{element} ");
    Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"где: {array1[0]} - максимальное значение массива");
Console.WriteLine($"{array1[1]} - индекс максимального значения массива");
Console.WriteLine($"{array1[2]} - минимальное значение массива");
Console.WriteLine($"{array1[3]} - индекс минимального значения массива");
Console.WriteLine($"{array1[4]} - среднеарифметическое всех значений массива");
 
if (array.Length % 2 == 0) median = (array[middleIndex - 1] + array [middleIndex])/2; 
else median = array[middleIndex];
Console.WriteLine($"Медианное значение массива: {median}");
}

int[] array = new int [8];
InitArray(array);
PrintArray(array);
Console.WriteLine();
Arifmetika(array);
