/*
Задача 2: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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


int [,] PrintArray2 (int [, ] array) // заменяет строки на столбцы (Почемуто выводит в терминал начальный и измененный массивы)
{
    int[,] Array2 = new int [array.GetLength(1), array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            Array2 [j, i] = array[i, j];
             Console.Write($"{Array2 [j, i]}\t");
         }
         System.Console.WriteLine();
    }
    return Array2;
}   

int [, ] arr = RandArray(4, 4);
int[, ] temp = PrintArray2(arr);
System.Console.WriteLine();
PrintArray2(temp);
