// Задача 2: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 67] -> 0



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

        int SumElements (int [] array) // Сумма нечетных элементов массива 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) 
        sum += array [i];
    }
    return sum;
}

int[] arr = RandArray(6);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна:" + SumElements(arr));
