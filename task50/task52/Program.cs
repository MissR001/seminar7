/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



int m = 3;
int n = 4;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Average(array);

void FillArray(int[,] arr)
{
    for ( int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(0,10);
        }
        
    }
  
}

void PrintArray(int[,] arr)
{
    for ( int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j],1}");
        }
        Console.WriteLine("");
    }
  
}


void Average(int[,] arr)
{double sum=0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    Console.WriteLine($"Среднее арифметическое  {sum/arr.GetLength(1)}");
}
}


