Console.Write("Write a five-digit number: ");
string fiveDigitString = Console.ReadLine()!;

for (int i = 0; i < fiveDigitString.Length / 2; i++)
{
    if (fiveDigitString[i] != fiveDigitString[fiveDigitString.Length - 1 - i])
    {
        Console.WriteLine("no");
        return;
    }
}
Console.WriteLine("yes");
