// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[4];

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 10); 
  System.Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.Write("Разница между максимальным и минимальным значением = ");


double max = array[0];
double min = array[0];

for (int i = 0; i < 4; i++)
    {
    if (max <= array[i])
    {
        max = array[i];
    }
    
    if (min > array[i])
    {
        min = array[i];
    }
    }
double result = max - min;

Console.WriteLine(result);

