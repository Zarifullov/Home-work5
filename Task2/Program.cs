// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
 

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 100); 
  System.Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.Write("Сумма элементов, стоящих на нечётных позициях = ");

int sum = 0;

int SumCount (int sum)
{
     
    for (int i = 0; i < 4; i = i+2)
    {
        int a = array[i];
        sum = sum + a;
    }
    return sum;
} 
Console.WriteLine(SumCount(sum));
