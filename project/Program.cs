void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"'{arr[i]}' ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void fillArray(int length, string[] arrToFill)
{
    for (int i = 0; i < length; i++)
    {
        arrToFill[i] = Console.ReadLine();
    }
}

void lessThan3Char(int length, int maxLength = 3)
{
    Console.WriteLine($"Введите {length} слов: ");

    string[] startArr = new string[length];

    fillArray(length, startArr);

    Console.WriteLine("Стартовый массив: ");

    PrintArray(startArr);

    int newLength = 0;
    for (int i = 0; i < startArr.Length; i++)
    {
        if (startArr[i].Length <= maxLength)
        {
            newLength += 1;
        }
    }
    string[] resultArray = new string[newLength];
    int newIndex = 0;
    for (int i = 0; i < startArr.Length; i++)
    {
        if (startArr[i].Length <= maxLength)
        {
            resultArray[newIndex] = startArr[i];
            newIndex++;
        }
    }
    Console.WriteLine("Финальный массив: ");
    PrintArray(resultArray);
}


lessThan3Char(5);