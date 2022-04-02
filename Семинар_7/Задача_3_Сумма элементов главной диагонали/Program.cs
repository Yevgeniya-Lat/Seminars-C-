/*
Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
Например, задан массив:
1   4   7
5   9   2
8   4   2
Сумма элементов главной диагонали: 1+9+2 = 12
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

int  DiagonalSumArray (int [, ] array) // Сумма элементов главной диагонали 
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if (i == j)

            sum +=  array[i, j];
         }
    }
    return sum;
}

int [, ] arr = RandArray(4, 4);
PrintArray(arr);
System.Console.WriteLine();
DiagonalSumArray(arr);
int Sum = DiagonalSumArray(arr);

System.Console.WriteLine($" Сумму элементов главной диагонали  равнв  " + Sum);


