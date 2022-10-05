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

int GetEvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] array = GetArray(8, 100, 999);
PrintArray(array);
Console.WriteLine(GetEvenCount(array));

