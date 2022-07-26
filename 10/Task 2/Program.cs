// Задача 2: Задайте массив строк. Напишите программу, которая 
// генерирует новый массив, объединяя элементы исходного массива попарно.

// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"





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
    else Console.Write("{"+stringArray[0]+", ");
    for (int i = 1; i < stringArray.Length; i++)
    {
        if (i==stringArray.Length-1)
        {
           Console.Write(stringArray[i]+"}"); 
        }
        else
        {
           Console.Write(stringArray[i]+", "); 
        }
        
    }
}

string[] ConnectTwoWords(string[]stringArray)
{
   if(stringArray.Length%2==0)
   {
     string[]connectedStringArray = new string[stringArray.Length/2];
      int j =0;
      for (int i = 0; i < stringArray.Length; i=i+2)
        {
            connectedStringArray[j]=stringArray[i]+stringArray[i+1];
            j++;
        }
        return connectedStringArray;
   }
   else 
   {
        string[]connectedStringArray2 = new string[stringArray.Length/2+1];
        int j =0;
        for (int i = 0; i < stringArray.Length-1; i=i+2)
        {
            connectedStringArray2[j]=stringArray[i]+stringArray[i+1];
            j++;
        }
        connectedStringArray2[connectedStringArray2.Length-1]=stringArray[stringArray.Length-1];

        return connectedStringArray2;
    }
  
}


Console.WriteLine($"Введите количество слов" );
int wordsNumber = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateStringArray( wordsNumber);


ShowStringArray(myArray);
Console.WriteLine();
ShowStringArray(ConnectTwoWords(myArray));





