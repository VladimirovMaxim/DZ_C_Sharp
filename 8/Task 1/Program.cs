// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
//  убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8


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

int[,] MinToMaxRow2DArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           int  rowIndMin = j;
           for (int j2 = j+1; j2 < matrix.GetLength(1); j2++)
           {
                if(matrix[i,rowIndMin] > matrix[i,j2] )
                {
                    rowIndMin=j2;
                }
           }
           int temp = matrix[i,j];
           matrix[i,j] = matrix[i,rowIndMin];
           matrix[i,rowIndMin]=temp;
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

int[,] my2DArray= CreateFillRandom2DArray( rows,columns, min,  max);

 Print2DArray(my2DArray);
 Console.WriteLine();
 Print2DArray(MinToMaxRow2DArray( my2DArray));
