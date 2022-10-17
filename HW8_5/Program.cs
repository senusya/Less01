void FillArraySpiral(int[,] array)
{

    int rows = array.GetLength(0);
    int collumns = array.GetLength(1);
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = array.GetLength(1);
    int counter = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[row, col] = counter++;
            if (--visits == 0) {
                visits = collumns * (dirChanges %2) + rows * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
              }
 
              col += dx;
              row += dy;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string txt = $"{array[i, j]} ";
            if (txt.Length < 3) {
                txt = $"0{txt}";
            }
            Console.Write(txt);
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


int[,] numbers = new int[4, 4];
FillArraySpiral(numbers);
PrintArray(numbers);