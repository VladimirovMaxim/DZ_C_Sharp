int[,,] CreateFillRandom3DArray(int length1, int length2, int length3,
 int minValue, int maxValue)
{
    int[,,] array3d = new int[length1, length2, length3];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                array3d[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array3d;
}

void Show3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}


int[] Convert3DArrayToArray(int[,,] array3D)
{
    int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];

    int index = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(1); k++)
            {
                array[index] = array3D[i, j, k];
                index++;
            }
        }
    }
    return array;
}

int[] MakeUniqueRandomArray(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] == array[j])  //  Мы сравниваем первое значение со всеми в массиве, и если есть совпаднени
                                       // мы полностью сравниваем повторяющиеся значение со всем массивом 
            {                         // до тех пор пока оно не станет уникальным
                int k = 0;
                while (k < array.Length)
                {
                    if (array[k] == array[j] && k != j)
                    {
                        array[j] = new Random().Next(minValue, maxValue + 1);
                        k = 0;
                    }
                    else k++;

                }
            }

        }
    }


    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[,,] ConvertArrayTo3DArray(int[] array, int length1, int length2, int length3)
{
    int[,,] array3D = new int[length1, length2, length3];
    int l = 0;
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                array3D[i, j, k] = array[l];
                l++;
            }
        }
    }
    return array3D;
}

Console.Write("Введите длину массива ");
int length1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину массива ");
int length2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите высоту массива ");
int length3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение  ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,,] my3darray = CreateFillRandom3DArray(length1, length2, length3, minValue, maxValue);
Show3DArray(my3darray);
Console.WriteLine();
Console.WriteLine("--------------");

int[] myArray = Convert3DArrayToArray(my3darray);

ShowArray(myArray);
Console.WriteLine();
Console.WriteLine("--------------");

int[] myArray2 = MakeUniqueRandomArray(myArray, minValue, maxValue);

ShowArray(myArray2);
Console.WriteLine();
Console.WriteLine("--------------");
Console.WriteLine("Финальный результат: ");
Console.WriteLine();
int[,,] my3darray2 = ConvertArrayTo3DArray(myArray2, length1, length2, length3);

Show3DArray(my3darray2);

