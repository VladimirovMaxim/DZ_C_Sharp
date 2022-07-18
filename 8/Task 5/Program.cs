// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7


int[,] FillSpiral2DArray(int length)
{
    int[,] array2D = new int[length, length];

   int j = 0, start = 0;

    while (start != length)
    {
        int i = start;
        for (j = start; j < length; j++)
        {
            Console.Write("Напишите значение ");
            array2D[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        j = length - 1;
        if (i == array2D.GetLength(0) / 2 && j == array2D.GetLength(1) / 2) break;

        for (i = start + 1; i < length; i++)
        {
            Console.Write("Напишите значение ");
            array2D[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        i = length - 1;
        for (j = length - 2; j >= start; j--)
        {
            Console.Write("Напишите значение ");
            array2D[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        j = start;
        start++;

        for (i = length - 2; i >= start; i--)
        {
            Console.Write("Напишите значение ");
            array2D[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        length--;
        

    }
    return array2D;

}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
 Console.Write("Напишите длину квадратного двумерного массива ");
int myNum= Convert.ToInt32(Console.ReadLine());

Print2DArray(FillSpiral2DArray(myNum));




