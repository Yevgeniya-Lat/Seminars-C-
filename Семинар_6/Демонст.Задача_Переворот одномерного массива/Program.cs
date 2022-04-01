/*
Демонстрация решения Семинар - 6
Задача 1: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/


        int[] RandArray(int Set)   // Создание рандомного массива в пределах(от и до)
{
    int[] answer = new int[Set];
    for (int i = 0; i < Set; i++)
    {
        answer[i] = new Random().Next(1, 50);
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


         void Reverse(int[] arr) // разворот массива
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Swap2(arr, i, arr.Length - 1 - i);
          //  (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
    }

}

/*
 void Swap(int[] arr, int i, int j) // обмен местами
{
    (arr[i], arr[j]) = (arr[j], arr[i]);
}
*/

void Swap2(int[] arr, int i, int j) // обмен местами через пересвоение
{
    int tmp = arr[i];
    arr[i] = arr[j];
    arr[j] = tmp;
    
}

 var array = RandArray(6);
 PrintArray(array);
 System.Console.WriteLine();
 Reverse(array);
 PrintArray(array);

