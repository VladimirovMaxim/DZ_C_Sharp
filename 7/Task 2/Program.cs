// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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

int ShowValueInMatrix(int i, int j, int[,] matrix)
{
    if(i>matrix.GetLength(0)|| j>matrix.GetLength(1)) 
    {
         return -22222;
    }

    int result = matrix[i-1, j-1];
    return result;
}




Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца ");
int j = Convert.ToInt32(Console.ReadLine());


int[,] matrix = CreateFillMatrix(m, n, min, max);
PrintMatrix(matrix);
if (ShowValueInMatrix(i, j, matrix) == -22222) Console.WriteLine("Такого числа не существует");
else Console.WriteLine("Значение равно "+ShowValueInMatrix(i, j, matrix));