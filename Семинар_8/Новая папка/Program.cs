/*
Задача 1: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

*/




int [, ] RandArray (int row, int colum)
{
    int [, ] array = new int [row, colum];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array [i, j] = rnd.Next(0, 10);
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


void Swap2(int [, ] array, arr) // обмен местами через пересвоение   ////
{
   
    for (int j = 0; j < array.GetLength(1); j++)   
    {
    int tmp = arr[0, j];
    arr[0, j] = arr[array.GetLength(1) - 1, j];
    arr[array.GetLength(1) - 1, j] = tmp;
    }
}


int [, ] arr = RandArray(4, 4);
PrintArray(arr);
System.Console.WriteLine();
Swap2(arr);

//DiagonalSumArray(arr);
//int Sum = DiagonalSumArray(arr);

//System.Console.WriteLine($" Сумму элементов главной диагонали  равнв  " + Sum);



