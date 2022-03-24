// Задача 1: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456-> 3
// 78-> 2
// 89126-> 5

/* Напишите программу, которая для рандомного числа выдает количество цифр в числе. */



string Randomize()
{
    Random rnd = new Random();
    int digit = rnd.Next();
    string newDigit = digit.ToString();
    return newDigit;
}

string number = Randomize();
int len = number.Length;

System.Console.WriteLine($"Количество цифр в числе {number} равно {len}.");
