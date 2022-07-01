
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumDigit(int num)
{
    int sum = 0;
    while(num !=0)
    {
        sum = sum + num%10;
        num = num /10;
    }
    return sum ;
}   
Console.WriteLine ("Напишите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumDigit(num);
Console.WriteLine($"Сумма всех цифр равна {sum}");

