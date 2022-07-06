// : Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] CreateRandomArray(int n, int min, int max)
{
	int [] array = new int[n];
	for(int i=0; i < array.Length; i++)
	{
		 array [i] = new Random().Next(min,max+1);
	}
	return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
	for (int i = 0; i< array.Length-1; i++)
	{
		Console.Write( array[i]+", " );
	}
    Console.Write(array[array.Length-1]+"]");
    Console.WriteLine(" ");
}

int EvenIndexSum(int[] array)
{
    int sum = 0;
    for(int i = 1; i< array.Length; i++)
        {
            if(i%2==1) sum = sum + array[i];
        }
    return sum;
}

Console.Write ("Введите длину массива: " );
int n =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение массива: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение массива: ");
int max =Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray( n, min, max);

ShowArray( array);
Console.WriteLine("Сумма равна " + EvenIndexSum(array) );