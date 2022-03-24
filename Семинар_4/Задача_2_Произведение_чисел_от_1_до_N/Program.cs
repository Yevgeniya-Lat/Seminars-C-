// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

/* Программа как для положительных так и для отрицательных чисел */

int N = Prompt("Введите число: ");
System.Console.WriteLine($"Произведение чисел от 1 до {N} равна {NumbersProduct(N)}");

     int NumbersProduct(int N)
{
    int product = 1;
 
        if(N > 1)
            {
                for(int i = 1; i <= N; i++)
                {
                    product = product * i;
                }
            }
        if(N < - 1)
            {
                for(int i = -2; i >= N; i= i-1)

                {
                   product = product * i;  
                }
            }            


 return product;
}


    int Prompt(string massage)
{
    Console.WriteLine(massage);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;

}
