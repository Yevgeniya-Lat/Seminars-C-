// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции нечётные, и замените эти элементы на их квадраты.



/*   Например, изначально массив
     выглядел вот так:
     1 4 7 2
     5 9 2 3
     8 4 2 4

    Новый массив будет выглядеть 
    вот так:
    1   4  7  2
    5  81  2  9
    8   4  2  4
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

int [, ] SquaredElementArray (int [, ] array) // Возведение в квадрат значений на нечетных позициях  
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if (i % 2 != 0 && j % 2 != 0)
            array[i, j] =  array[i, j] * array[i, j];
         }
    }
    return array;
}

int [, ] arr = RandArray(4, 4);
PrintArray(arr);
System.Console.WriteLine();
SquaredElementArray(arr);
PrintArray(arr);

