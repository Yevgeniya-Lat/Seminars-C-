/*  Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/


            int Prompt(string massage) 
{
    Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

int a = Prompt("Введите десятичное число: ");
int [] b =  new int [10];  
int c = 0;
int i = 0;
while ( a >= 1 )
{
   c = a % 2;
   b[i] = c;
   a = a / 2;
   i++;

} 
    for (int j = i - 1; j >= 0; j--)
    System.Console.Write(b[j]);
