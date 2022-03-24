// Задача 1: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456-> 3
// 78-> 2
// 89126-> 5

/* Программа с проверкой, если ввели не число */

string Prompt(string massage)
{
    System.Console.WriteLine(massage);
    string stringValue = Console.ReadLine();

    return stringValue;
}


string number = Prompt("Введите число: ");
int len = number.Length;
int temp = int.Parse(number);

    if(temp <= 0 || temp > 0)
        System.Console.WriteLine($"Количество цифр в числе {number} равно {len}.");

    else
    System.Console.WriteLine("Введено не число.");




