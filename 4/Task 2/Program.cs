// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void CreateShowArray(int []array , int min, int max)
{
    max = max +1;
    int size=array.Length - 1;
    Console.Write("[");
    for(int i = 0;i<size; i++ )
    {
        array[i] = new Random().Next(min, max);
        Console.Write(array[i] + ", ");
    }
    array[size] = new Random().Next(min, max);
    Console.Write(array[size] + "]");

}
int[] array = new int[8];

Console.WriteLine("Введите максимальное значение в массиве ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в массиве ");
int min = Convert.ToInt32(Console.ReadLine());




CreateShowArray(array ,  min,  max);