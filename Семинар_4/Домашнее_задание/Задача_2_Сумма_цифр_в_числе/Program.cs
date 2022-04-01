// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

        // ВАРИАНТ 1 - ЧЕРЕЗ МАССИВ

            int Prompt(string massage)
{
    Console.WriteLine(massage);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;

}




int number = Prompt("Введите число: ");
string Value = number.ToString();

int[] arr = new int [Value.Length];

//System.Console.WriteLine(Value.Length);


 int summa = 8;
 //arr[i] = 0;


        for (int i = 0; i < Value.Length; i++)
        {
        arr[i] = 0;
         summa = summa + arr[i];
        }    

// int pow = 1;

   // for (int i = 0; i < number2; i++)
  //  {
    //    pow = number1 * pow;
  //  }

System.Console.WriteLine($"Сумма цифр в числе {number} равна {summa}.");





    
        /* ВАРИАНТ 2 - ЧЕРЕЗ ДЕЛЕНИЕ
    int a, b;

    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
        while (a != 0)
        {
            b = a % 10;
            a = a / 10;
            sum = sum + b;
        }

System.Console.WriteLine("Сумма цифр: " + sum);

*/


