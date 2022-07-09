// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void InputAndCountPositive(int m)
{
    
    int i = 1;
    int count = 0;
    while(i <= m)
    {
        Console.Write("Введите число ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count ++;
        i++;
    }
    Console.WriteLine(count + " числа (чисел) больше нуля");
}

Console.WriteLine("Сколько чисел вы планируете ввести?");
int m = Convert.ToInt32(Console.ReadLine());
InputAndCountPositive( m);

