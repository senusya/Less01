int[] GetArray(int arrayLenght, int min, int max)
{
    int[] array = new int[arrayLenght];
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]\n");
}

int GetMinMaxDiff(int[] array)
{
    int min = 100;
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        else if (max < array[i])
        {
            max = array[i];
        }
    }
    return max - min;
}


int[] array = GetArray(8, 10, 99);
PrintArray(array);
Console.WriteLine(GetMinMaxDiff(array));

