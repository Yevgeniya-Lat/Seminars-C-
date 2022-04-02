﻿/*
Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int [, ] FillArray (int row, int colum) // Массив  по формуле А = m + n
{
    int [, ] array = new int [row, colum];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i, j] =  i + j;
         }
    }
    return array;
}

void PrintArray (int [, ] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write($"{array [i, j]}\t");
         }
    System.Console.WriteLine();
    }
}   


int[, ] arr = FillArray(3, 4);

PrintArray(arr);




