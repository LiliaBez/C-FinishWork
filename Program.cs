/*Написать программу, которая из имеющегося массива 
сток формирует массив из строк, длина которых меньше, 
либо равна 3 символа.*/

Console.WriteLine("Введите текст через пробел: ");

string text = Console.ReadLine()!;
string[] textArray = text.Split(' ');
string[] finishText = new string[textArray.Length];

FindStringLessThree(textArray);
PrintArray(finishText);


void FindStringLessThree (string[] textArray)
{
    int j = 0;
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length <= 3)
        {
        finishText[j] = textArray[i];
        j++;
        }
    }
}

void PrintArray (string[] finishText)
{
    for (int j = 0; j < finishText.Length; j++)
    {
        Console.Write($"{finishText[j]} ");
    }
    Console.WriteLine();
}



