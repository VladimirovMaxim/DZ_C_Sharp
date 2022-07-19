// Задача 64: Задайте значение N. Напишите программу, 
// которая найдет факториал числа N рекурсивным методом.

// N = 4 -> 24

int Factorial(int n)
{
    if (n>0)
    {
        return n * Factorial(n-1);
    }
    return 1;
}


Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Факториал {n} равен {Factorial(n)}");