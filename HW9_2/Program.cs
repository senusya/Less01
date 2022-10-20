Console.WriteLine("Write M:");
int m = int.Parse(Console.ReadLine()!);
int n = 0;

while (n < m) 
{
    Console.WriteLine($"Write N > {m}:");
    n = int.Parse(Console.ReadLine()!);
}

int GetSum(int from, int to, int sum = 0) {
    if (to == from) {
        return sum + to;
    }

    return GetSum(from + 1, to, sum + from);
}

Console.WriteLine($"M = {m}; N = {n} -> \"{GetSum(m, n)}\"");