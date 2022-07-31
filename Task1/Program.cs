// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

int[] array = new int[4];
 

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(100, 999); 
  System.Console.Write($"{array[i]} ");
}

int result = 0;

int Count (int result)
{
     
    for (int i = 0; i < 4; i++)
    {
        int a = array[i];
        if(a % 2 == 0)
        {
            result = result + 1;
        }
        
    }
    return result;
} 
Console.WriteLine(Count(result));
