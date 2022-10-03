int Power(int firstNumber, int secondNumber)
{
    int result = firstNumber;

    while (secondNumber > 1)
    {
        result = result * firstNumber;
        secondNumber--;
    }

    return result;
}

Console.WriteLine("Write a first number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write a second number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

int result = Power(firstNumber, secondNumber);

Console.WriteLine(result);