Console.WriteLine("Write first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write second number: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Write third number: ");
int number3 = int.Parse(Console.ReadLine());

if ((number1 > number2) &  (number1 > number3))
{
    Console.WriteLine($"max = " + number1);
}
else if ((number2 > number1) & (number2 > number3))
{
    Console.WriteLine($"max = " + number2);
}
else
{
    Console.WriteLine($"max = " + number3);
}