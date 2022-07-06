// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] CreateRandomArray(int n)
{
	int [] array = new int[n];
	for(int i=0; i < array.Length; i++)
	{
		 array [i] = new Random().Next(100,1000);
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

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}


Console.Write ("Введите длину массива : " );
int n =Convert.ToInt32(Console.ReadLine());

int[] array =  CreateRandomArray( n);
ShowArray(array);
Console.Write("Четных чисел в массиве:" + EvenNumber(array));