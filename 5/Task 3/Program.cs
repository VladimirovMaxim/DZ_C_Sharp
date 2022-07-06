// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] RandomRealNumberArray(int n, int min, int max)
{
	double [] array = new double[n];
	for(int i=0; i < array.Length; i++)
	{
		int a = new Random().Next(min,max+1);
        double b = new Random().NextDouble();
         b = Math.Round(b,2);
        array [i] = a+b;
    }
   
	return array;
}

void ShowArray(double[] array)
{
    Console.Write("[");
	for (int i = 0; i< array.Length-1; i++)
	{
		Console.Write( array[i]+"  " );
	}
    Console.Write(array[array.Length-1]+"]");
    Console.WriteLine(" ");
}

double  DifMaxMinArray(double[] array)
{
    
    double min = array[0];
    double max = array[0];
    for(int i=1; i<array.Length; i++ )
    {
        if(max< array[i]) max = array[i];
        if (min> array[i]) min = array [i];
    }
    double dif = max - min;
    return dif;
}


Console.Write ("Введите длину массива : " );
int n =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное значение массива: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное значение массива: ");
int max =Convert.ToInt32(Console.ReadLine());

double [] array = RandomRealNumberArray( n, min, max);
 ShowArray( array);
 Console.WriteLine ("Разница равна " + DifMaxMinArray( array));
