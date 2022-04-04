// ВИДЫ ТИПЫ МЕТОДОВ

    // ВИД 1  ----- МЕТОД НИЧЕГО НЕ ВОЗВРАЩАЕТ
/*   void Metod1 // 
    {
        System.Console.WriteLine("Автор: ...");
    }
    Metod1();
 */

    // ВИД 2 ---МЕТОД НИЧЕГО НЕ ВОЗВРАЩАЕТ
/*
    void Metod2(string msg)
    {
        System.Console.WriteLine(msg);
    }
Metod2(msg: "Текст сообщения");    

    void Metod21(string msg, int count)
    {
        int i = 0;
        while (i < count)
        {
            i++;
            System.Console.WriteLine(msg);
        }
    }
    Metod21(msg: "Текст", count: 4);
    Metod21(count: 2, msg: "Текст поменяли местами");
*/

    // ВИД 3 --- МЕТОД С ВОЗВРАЩЕНИЕМ
/*
int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
System.Console.WriteLine(year);
*/

    // ВИД 4 --- МЕТОД КОТОРЫЙ ЧТО-ТО ПРИНИМАЕТ И ЧТО-ТО ВОЗВРАЩАЕТ
/*
 string Metod4(int count, string text)
{
    int i = 0;  
    string result = String.Empty;

        while (i < count)
        {
            i++;
            result = result + text;
        }
    return result;    
}

string res = Metod4(10, "*ЛЮБОВЬ*");
System.Console.WriteLine(res);
*/




/*    void PrintArray(int[,] matrix)  // -- ВЫВОД ДВУХМЕРНОГО МАССИВА--
{
    for (int i = 0; i < matrix.GetLength(0); i++)  // ВМЕСТО СТАНДАРТНОЙ ЗАПИСИ i < 3; ПИШЕМ в данном случае matrix.GetLength(0);
  {
    for (int j = 0; j < matrix.GetLength(1); j++)  // ВМЕСТО СТАНДАРТНОЙ ЗАПИСИ j < 4; ПИШЕМ в данном случае matrix.GetLength(1);
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
  }

}*/

/*    void RandArray(int[,] matr)    // -- РАНДОМНЫЙ ДВУХМЕРНЫЙ МАССИВ --
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);  // Интервал можно менять произвольно
        }
    }
}   */

/*    void PrintImage(int[, ] image)     // МЕТОД ДЛЯ КАРТИНКИ для изменения 1 на +
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j= 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
            Console.Write($" ");
            else Console.Write($"+");
        } 
        Console.WriteLine();
    }
}*/

/*    void PaintImage(int row, int col)  // МЕТОД ДЛЯ КАРТИНКИ (с рекурсией)  для закрашивания области внутри контура
{
    if (pic[row, col] == 0 )
    {
         pic[row, col] = 1;
         PaintImage(row - 1, col); 
         PaintImage(row, col - 1); 
         PaintImage(row + 1, col); 
         PaintImage(row, col + 1); 
    }
}*/

/*    double Factorial(int N)     // МЕТОД (с рекурсией) ВЫВОДА РЯДА ФАКТОРИАЛА ОТ 1 ДО N ЧИСЛА
{
    if (N == 1)
        return 1;
    else return N * Factorial(N - 1);
} 
         for (int i = 1; i < 7; i++)
          {
              System.Console.WriteLine($"{i} != {Factorial(i)}");
          }
   */    

/*    int Fibonacci(int n)  // МЕТОД (с рекурсией) ВЫВОД РЯДА ЧИСЕЛ ФИБОНАЧЧИ
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
    for (int i = 1; i < 10; i++)
        {
            System.Console.WriteLine(Fibonacci(i));
        }
*/

/*     string Metod (int count, string text) // Метод который что-то принимает и что-то выдает
{
    string result = String.Empty;
        for ( int i = 0; i < count; i++)
        {
            result = result + text;
        }
    return result;    
}*/

/*    string Replace(string text, char oldValue, char newValue) // Метод замены символа в строке
{
    string result = String.Empty;
        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            if (text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
        }

    return result;
}*/

/*    void PrintArr(int[] array) // Вывод одномерного массива
{
   // int count = array.Length; - если такое пишем, то в for обязательно меняем!!!!! array.Length на count
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    System.Console.WriteLine();
}*/

/*    void SelectionSort(int[] array) // Сортировка одномерного массива от min к max
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition])
                minPosition = j;
            }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
} */

/*    for (int i = 2; i <= 10; i++) // Цикл в цикле на примере таблицы умножения
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}*/


/*  void Swap2(int[] arr, int i, int j) // обмен местами через пересвоение
{
    int tmp = arr[i];
    arr[i] = arr[j];
    arr[j] = tmp;
    
}*/


/*  void Swap(int[] arr, int i, int j) // обмен местами
{
    (arr[i], arr[j]) = (arr[j], arr[i]);
}

       void Reverse(int[] arr) // разворот массива
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Swap2(arr, i, arr.Length - 1 - i);
          //  (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
    }

}*/

/*       void PrintArray(int[] Mas) // Вывод одномерного массива
{
    int count = Mas.Length;
        for (int pos = 0; pos < count - 1; pos++)
            {
                Console.Write(Mas[pos] + " ,");
            }
        System.Console.WriteLine(Mas[Mas.Length -1]);    // чтобы в конце лишняя запятая не появлялась
}*/

/*       int[] RandArray(int Set)   // Создание рандомного массива в пределах(от и до)
{
    int[] answer = new int[Set];
    for (int i = 0; i < Set; i++)
    {
        answer[i] = new Random().Next(1, 50);
    }
    return answer;
}

*/



