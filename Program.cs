using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк
        Console.WriteLine("Введите массив через запятую и пробел:");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(new[] { ", " }, StringSplitOptions.None);

        // Формирование нового массива из строк длиной <= 3 символов
        string[] newArray = GetShortStringsArray(initialArray);

        // Вывод массива
        Console.WriteLine("Результат:");
        foreach (string item in newArray)
        {
            Console.Write(item + " ");
        }

        Console.ReadLine();
    }

    static string[] GetShortStringsArray(string[] initialArray)
    {
        int count = 0;
        foreach (string item in initialArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string item in initialArray)
        {
            if (item.Length <= 3)
            {
                newArray[index] = item;
                index++;
            }
        }

        return newArray;
    }
}

