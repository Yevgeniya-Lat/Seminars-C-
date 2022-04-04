/*
Задача 1. Напишите программу, которая на вход принимает два числа и проверяет,
является ли второе число квадратом первого.

a = 5; b = 25 -> да 
a = 2 b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3 b = 9 -> да
*/

Console.WriteLine("Введите  первое число: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите  второе число: ");
    int SecondtNum = Convert.ToInt32(Console.ReadLine());

    if(SecondtNum == firstNum * firstNum)
        Console.WriteLine($"ДА  - Второе число {SecondtNum} ЯВЛЯЕТСЯ квадратом первого числа {firstNum}");
    
    else Console.WriteLine($"НЕТ - Второе число {SecondtNum}  НЕ ЯВЛЯЕТСЯ квадратом первого числа {firstNum}");
