// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49


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

int [,] MultiplyTwoMatrix(int[,]matrix,int[,]matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=matrix[i,j]*matrix2[i,j];
        }
    }
    return matrix;
}

Console.Write ("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());



int[,] myMatrix1= CreateFillRandom2DArray( rows,columns, min,  max);
int[,] myMatrix2= CreateFillRandom2DArray( rows,columns, min,  max);



Print2DArray(myMatrix1);
Console.WriteLine();
Print2DArray(myMatrix2);
Console.WriteLine();
Print2DArray(MultiplyTwoMatrix(myMatrix1,myMatrix2));
