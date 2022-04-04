/*
Задача 4. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/


Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 =  - number1;

System.Console.Write( number2 + ", ");
while (number2  < number1)
{
    number2 ++;
    
System.Console.Write(number2  + ", ");
}



