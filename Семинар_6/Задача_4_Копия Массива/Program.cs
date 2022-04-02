// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

             int[] RandArray(int Length)
{
    int[] answer = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        answer[i] = new Random().Next(0, 100);

    }
    return answer;
}

            void PrintArray(int[] Mas)
            {
                int count = Mas.Length;
                for(int pos = 0; pos < count; pos++)
                {
                    Console.Write(Mas[pos] + " ,");

                }
         System.Console.WriteLine();
            }

int[] arrey = RandArray(10);
int[] arrey2 = RandArray(arrey.Length);
for(int i = 0; i < arrey.Length; i++)
{
    arrey2[i] = arrey[i];

}
PrintArray(arrey);
PrintArray(arrey2);