void PrintArray(string[] arr)
{
    Console.Write($"Массив: [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

int FindLngthOfString(string str)
{
    int lngth = 0;
    for (int i = 0; i < str.Length; i++)
    {
        lngth++;
    }
    return lngth;
}

void Test1()
{
    string[] arr = { "what", "are", "you", "doing", "here", ":)", "?" };
    PrintArray(arr);
    int size = arr.Length;
    int j = 0;
    string[] newArr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        if (FindLngthOfString(arr[i]) < 4)
        {
            newArr[j] = arr[i];
            j++;
        }
        else size--;
    }
    string[] finalArr = new string[size];
    for (int i = 0; i < finalArr.Length; i++)
    {
        finalArr[i] = newArr[i];
    }
    PrintArray(finalArr);
}

Test1();