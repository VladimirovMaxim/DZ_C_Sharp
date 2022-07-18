// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateFillRandom2DArray(int rows,int columns, int min, int max)
{
    int[,] array2D = new int[rows,columns];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i,j] = new Random().Next(min,max+1);
            
        }
    }
    return array2D;
}
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j] + " "); 
        }
        Console.WriteLine();
    }
}

int MinSumValuesInRow(int[,] matrix)
{
    int minSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
           minSum += matrix[0,j];
        }
    int rowNumber =1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
         int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if(minSum > sum)
        {
            minSum = sum;
            rowNumber = i+1;
        }
    }
    return rowNumber;
}

Console.Write ("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] my2DArray= CreateFillRandom2DArray( rows,columns, min,  max);

 Print2DArray(my2DArray);
 Console.WriteLine($"Номер строки с наименьшей суммой : {MinSumValuesInRow(my2DArray)} строка");
 