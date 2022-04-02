// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

            int Prompt(string massage)
{
    Console.WriteLine(massage);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

             void Rand(int[]Set)
{
    int lenght = Set.Length;
    for (int i = 0; i < lenght; i++)
    {
        Set[i] = new Random().Next(1, 50);
    }
}

            void console(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
}

int number = Prompt("Введите длину массива:");
int[] array = new int[number];

Rand(array);
console(array);