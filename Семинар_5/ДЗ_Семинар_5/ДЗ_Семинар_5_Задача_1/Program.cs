// Задача 1: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



       int[] RandArray(int Set)   // Создание рандомного массива в пределах(от и до)
{
    int[] answer = new int[Set];
    for (int i = 0; i < Set; i++)
    {
        answer[i] = new Random().Next(100, 1000);
    }
    return answer;
}


       void PrintArray(int[] Mas) // Вывод одномерного массива
{
    int count = Mas.Length;
        for (int pos = 0; pos < count - 1; pos++)
            {
                Console.Write(Mas[pos] + " ,");
            }
        System.Console.WriteLine(Mas[Mas.Length -1]);    // чтобы в конце лишняя запятая не появлялась
}

        int EvenNumbers (int [] array)  // Счетчик четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}




int[] arr = RandArray(10);
PrintArray(arr);
System.Console.WriteLine();
Console.WriteLine($"Количество  чётных чисел в массиве равно {EvenNumbers(arr)} .");      