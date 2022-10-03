int SumOfDigits(string digits)
{
    int result = 0;

    for (int i = 0; i < digits.Length; i++)
    {
        result = result + int.Parse(digits[i].ToString());
    }

    return result;
}


Console.Write("Write a number: ");
string number = Console.ReadLine()!;
int result = SumOfDigits(number);
Console.WriteLine(result);
