// Задача 1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


            void PrintArray(int[] Mas)
{
    int count = Mas.Length;
        for (int pos = 0; pos < count; pos++)
        {
            System.Console.Write(Mas[pos] + " ,");
        }
    System.Console.WriteLine();
}

            int[] RandomArray(int Length)
    {
        int[] answer = new int[Length];
         for (int i = 0; i < Length; i++)
          {
              answer[i] = new Random().Next(-9, 10);
          }
        return answer;

    }

int[] arr = RandomArray(10);
PrintArray(arr);

     for (int i =0; i < arr.Length; i++)
      {
           arr[i] = -arr[i];
      }
        PrintArray(arr);        