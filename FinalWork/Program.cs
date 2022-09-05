Console.Clear();

string[] ReadToFillArray(string text)
{
    Console.Write(text);

    string[] array = Console.ReadLine().Split(" ");

    return array;
}

string[] CutLongLines(string[] inputArray)
{
    int count = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3 && inputArray[i].Length >= 1)
        {
            count++;
        }
    }

    if (count == 0)
    {
        string[] emptyArray = new string[1];
        return emptyArray;
    }

    string[] outputArray = new string[count];
    count = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3 && inputArray[i].Length >= 1)
        {
            outputArray[count] = inputArray[i];
            count++;
        }
    }
    return outputArray;
}

void PrintArray(string[] inputArray)
{
    int i = 0;
    Console.Write("[");

    while (i < inputArray.Length - 1)
    {
        Console.Write("\"" + inputArray[i] + "\", ");
        i++;
    }

    Console.WriteLine("\"" + inputArray[i] + "\"]");
}

string[] arrayLines = ReadToFillArray("Введите что хотите, через пробел: ");

string[] newArray = CutLongLines(arrayLines);

PrintArray(newArray);
