// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateFillMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);

        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
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

void ColumnAverage(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
           sum += matrix[j,i];
        }
        double average = sum / matrix.GetLength(0);
        Console.Write($"Среднее арифметическое столбца {i+1} равно " + average);
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix =  CreateFillMatrix( m,  n,  min, max);
PrintMatrix(myMatrix);
ColumnAverage(myMatrix);