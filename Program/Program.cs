﻿void PrintArray(string[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

string[] ChangeArray(string[] array)
{
    int maxLengthStr = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthStr)
        {
            j++;
        }
    }
    string[] newArray = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthStr)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] array = { "123", "1234", "qwerty", "qwe", ":)" };
PrintArray(array, "Первоначальный массив:");
array = ChangeArray(array);
PrintArray(array, "Изменённый массив:");
