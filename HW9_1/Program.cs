Console.WriteLine("Write number:");
int number = int.Parse(Console.ReadLine()!);

string GenerateStringWithNumbers(int number, string str = "") {
    if (number == 0) {
        return str;
    }
    str = str.Length == 0 ? $"{number}" : $"{str}, {number}";
    return GenerateStringWithNumbers(number - 1, str) ;
}

Console.WriteLine($"N = {number} -> \"{GenerateStringWithNumbers(number)}\"");