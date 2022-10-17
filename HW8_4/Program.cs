void FillArray(int[,,] array)
{

   
    int counter = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = counter++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             for (int k = 0; k < array.GetLength(2); k++) {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
             }
             Console.WriteLine("");
        }
    }
}

int[,,] numbers = new int[2, 2, 2];
FillArray(numbers);
PrintArray(numbers);