/*
*. Напишите программу вычисления модуля числа.
2 -> 2
-3 -> 3
-7 -> 7

*/

System.Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());

 if (number < 0)
      System.Console.WriteLine(- number);

else  System.Console.WriteLine( number);
