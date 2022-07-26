// Задача 1: Задайте массив строк. Напишите программу, 
// считает кол-во слов в массиве, начинающихся на гласную букву.

// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1


string [] CreateStringArray(int wordsNumber)
{
    string[] wordsArray = new string[wordsNumber];
    for (int i = 0; i < wordsNumber; i++)
    {
        Console.WriteLine($"Введите {i+1} слово ");
        wordsArray[i] = Console.ReadLine();
    }
    return wordsArray;
}   
void ShowStringArray(string[]stringArray)

{  
     if(stringArray.Length==1)  Console.Write("{"+stringArray[0]+"}");
    else Console.Write("{"+stringArray[0]+",");
    for (int i = 1; i < stringArray.Length; i++)
    {
        if (i==stringArray.Length-1)
        {
           Console.Write(stringArray[i]+"}"); 
        }
        else
        {
           Console.Write(stringArray[i]+","); 
        }
        
    }
}

int CountWordsWithFirstVowels(string[]stringArray)
{
    int count = 0;
    char[] vowels = {'a','e','y','u','i',
    'o','у','е','ы','а','о','э','я', 'и', 'ю'};
    for (int i = 0; i < stringArray.Length; i++)
    {
       for (int j = 0; j < vowels.Length; j++)
       {
        if(stringArray[i][0]==vowels[j]) count++;
       } 
    }
    return count;
}

Console.WriteLine($"Введите количество слов" );
int wordsNumber = Convert.ToInt32(Console.ReadLine());

string[] myArray =  CreateStringArray(wordsNumber);
ShowStringArray(myArray);
Console.WriteLine();
Console.WriteLine(CountWordsWithFirstVowels(myArray)+" слово(а) начинаются с гласной ");