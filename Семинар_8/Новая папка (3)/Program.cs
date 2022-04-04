/*
Задача 3: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
Значения элементов массива 0..9

 Набор данных                    Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
                                0 встречается 2 раза 
                                1 встречается 1 раз 
                                2 встречается 1 раз 
                                8 встречается 1 раз 
                                9 встречается 3 раза
1, 2, 3 
4, 6, 1 
2, 1, 6
                                1 встречается 3 раза 
                                2 встречается 2 раз 
                                3 встречается 1 раз 
                                4 встречается 1 раз 
                                6 встречается 2 раза

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




int [, ] arr = RandArray(4, 4); 
PrintArray(arr);
System.Console.WriteLine();


