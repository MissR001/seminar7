/*Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// 1 способ


/*
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max);
{
int [,] matrix = new int[rows, columns];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(min, max + 1);
    }
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i< matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, (-100, 100)/10);
PrintMatrix(array2d);

*/



// 2 способ

int m = 3, n = 4;
double[,] matrix = new double[m,n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = (double)rnd.Next(-100, 100)/10;
        Console.Write(matrix[i,j] + " ");
    }
Console.WriteLine();
}


