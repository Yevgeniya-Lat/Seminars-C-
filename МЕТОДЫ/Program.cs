/*

void Swap2(int[] arr, int i, int j) // обмен местами через пересвоение
{
    int tmp = arr[i];
    arr[i] = arr[j];
    arr[j] = tmp;
    
}


void Swap(int[] arr, int i, int j) // обмен местами
{
    (arr[i], arr[j]) = (arr[j], arr[i]);
}

       void Reverse(int[] arr) // разворот массива
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Swap2(arr, i, arr.Length - 1 - i);
          //  (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
    }

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

       int[] RandArray(int Set)   // Создание рандомного массива в пределах(от и до)
{
    int[] answer = new int[Set];
    for (int i = 0; i < Set; i++)
    {
        answer[i] = new Random().Next(1, 50);
    }
    return answer;
}

*/