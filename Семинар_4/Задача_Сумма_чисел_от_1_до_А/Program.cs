// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7-> 28
// 4-> 10
// 8-> 36


int digit = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма чисел от 1 до {digit} равна {NumberSum(digit)}");

int NumberSum(int digit)
{
    
    int sum = 0;
    for(int i = 1; i <= digit; i++)
    {
        sum += i;
    }
 return sum;
}


int Prompt(string massage)
{
    Console.WriteLine(massage);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;

}
