// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


    void FindArray(int[] array)
{
    Random random = new Random();
        for(int i = 0; i < array.Length; i++ )
        {
            array[i] = random.Next(0, 2);
        }

}

    void PrintArray(int[] Array)
{
    System.Console.Write("[");

        for(int i = 0; i < Array.Length-1; i++)
        {
            System.Console.Write(Array[i] + ",");
        }
      System.Console.Write(Array[7] + "]");  
}

int[] array = new int[8];

FindArray(array);
PrintArray(array);