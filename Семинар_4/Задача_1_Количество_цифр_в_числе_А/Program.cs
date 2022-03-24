// Задача 1: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456-> 3
// 78-> 2
// 89126-> 5


string number = Prompt("Введите число: ");
int len = number.Length;
int temp = int.Parse(number);

int i = 1;

    while (temp / 10 != 0)
{
    temp = temp/10;
    i++;
}


    string Prompt(string massage)
{
    Console.WriteLine(massage);
    string Value = Console.ReadLine();
   
    return Value;

}

System.Console.WriteLine($"Количество цифр в числе {number} равно {i}");