Console.WriteLine("Write m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write n:");
int n = int.Parse(Console.ReadLine()!);

int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (m != 0 && n == 0)
        {
            return GetAkkerman(m - 1, 1);
        }
        else
        {
            return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
        }
    }


}

Console.WriteLine($"m = {m}; n = {n}  -> A(m,n) = {GetAkkerman(m, n)}");