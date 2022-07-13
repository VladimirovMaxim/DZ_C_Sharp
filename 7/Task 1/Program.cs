// Задача 47. Задайте двумерный массив размером m×n, з
// аполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] CreateMatrix(int m,int n, int min, int max)
{
   double[,] matrix = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int a = new Random().Next(min,max);
            double b = new Random().NextDouble();
            b = Math.Round(b,1);
            matrix [i,j] = a+b;
            
        }
    }
    return matrix;
}

void PrintMatrix(double [,] matrix)
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

Console.Write ("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

PrintMatrix(CreateMatrix(m,n,  min,  max));
