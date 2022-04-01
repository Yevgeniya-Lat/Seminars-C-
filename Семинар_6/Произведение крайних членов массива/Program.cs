/*Задача 4: Найдите произведение пар чисел в одномерном массиве. 
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

            void PrintArray(int[] Mas) // Вывод одномерного массива
{
    int count = Mas.Length;
        for (int pos = 0; pos < count; pos++)
            {
                Console.Write(Mas[pos] + " ,");
            }
        System.Console.WriteLine();    
}  

             void Rand(int[]Set)   // Создание рандомного массива в пределах(от и до)
{
    int lenght = Set.Length;
    for (int i = 0; i < lenght; i++)
    {
        Set[i] = new Random().Next(1, 50);
    }
}


            void Proizv(int[] arr)  // Произведение крайних членов массива и вывода нового массива
{
    int[] result = new int [arr.Length / 2 ];
    for (int i = 0; i < arr.Length/2; i++ )
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
       Console.Write(result[i] + " ,");
    }
}

int [] array = new int [5];
Rand(array);
PrintArray(array);
System.Console.WriteLine();
int[] Array = array;
Proizv(Array);


