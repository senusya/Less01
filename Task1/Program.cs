Console.WriteLine("Write first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"max = " + number1);
}
else
{
    Console.WriteLine($"max = " + number2);
}
