
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого элемента в массиве нет
*/

int m = 3;
int n = 4;
int [,] arr = new int[m, n];
Console.WriteLine("Введите значение: ");
int number = Convert.ToInt32 (Console.ReadLine());
FillArray (arr);
FindElementArray (arr, number);

void FillArray(int [,] arrayToFill){
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(1,10);
            Console.Write (arr [i, j]+ " ");
        }
        Console.WriteLine ();
    }
}


void FindElementArray (int [,] findelement, int usernumber){
      bool find = false;
      for (int i = 0; i < findelement.GetLength(0); i++)
    {
        for (int j = 0; j < findelement.GetLength(1); j++)
       {
        if(findelement [i,j] == usernumber)
        Console.WriteLine("Значение элемента в массиве " + i + " " + j);
           find = true;
        }
       }
    
    if (!find)
    Console.WriteLine("Такого элемента в массиве нет");
}









