﻿/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2 && num1 > num3)
        System.Console.WriteLine("max = " + num1);
    if (num2 > num1 && num2 > num3)
        System.Console.WriteLine("max = " + num2);
    if (num3 > num2 && num3 > num1)
        System.Console.WriteLine("max = " + num3);
