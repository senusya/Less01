void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Write a number of lines: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write a number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandom(numbers);
PrintArray(numbers);

