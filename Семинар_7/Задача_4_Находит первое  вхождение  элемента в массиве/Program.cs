/*
Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4

Введенный элемент 2, результат: [0, 3]

Введенный элемент 6, результат: такого элемента нет.


*/

 int Prompt(string message)
{
    System.Console.WriteLine(message);
    string stringValue = Console.ReadLine();
    int Value = int.Parse(stringValue);

return Value;    
}



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


int  DiagonalSumArray (int [, ] array) // Находит первое  вхождение  элемента в массиве
{
    int element = Prompt("Введите число:  .");

    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if (array[i, j] == element)
            break;
         }
         Console.WriteLine($"Введенный элемент {element}, результат: []");
    }
    return   ;
    Console.WriteLine($"Введенный элемент {element}, результат: такого элемента нет.");
}





int [, ] arr = RandArray(4, 4);
PrintArray(arr);
System.Console.WriteLine();
DiagonalSumArray(arr);
//int Sum = DiagonalSumArray(arr);

//System.Console.WriteLine($" Сумму элементов главной диагонали  равнв  " + Sum);



