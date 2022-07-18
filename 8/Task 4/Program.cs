// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно
//  выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int [,,] CreateFiilInput3DArray(int length1, int length2, int length3)
{
    int[,,] array3D = new int[length1,length2,length3];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                Console.Write ("Введите  уникальное двухзначное  число ");
                array3D[i,j,k]= Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    return array3D;
}

void Show3DArray(int[,,]array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write ("Введите длину массива ");
int length1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите ширину массива ");
int length2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите высоту массива ");
int length3 = Convert.ToInt32(Console.ReadLine());

Show3DArray(CreateFiilInput3DArray(length1,  length2,  length3));