// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

    int Prompt(string message)
{
    System.Console.WriteLine(message);
    string stringValue = Console.ReadLine();
    int Value = int.Parse(stringValue);

return Value;    
}

int N = Prompt("Введите число:  .");
int i = 1;

    Console.Write(i + " ");

while (i < N)
{
    i++;
    System.Console.Write(i*i + " ");
}
   