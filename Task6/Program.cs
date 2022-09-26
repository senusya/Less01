Console.WriteLine("Write number: ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("There is no third digit");
}
else 
{
    while (number > 1000)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}