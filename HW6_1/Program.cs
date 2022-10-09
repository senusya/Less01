Console.Write("Write a count of numbers: ");
int countOfNumbers = int.Parse(Console.ReadLine()!);

int countOfPositiveNumbers = 0;

while (countOfNumbers > 0)
{
    Console.Write("Write a number: ");
    int number = int.Parse(Console.ReadLine()!);
    if (number > 0)
    {
        countOfPositiveNumbers++;
    }
    countOfNumbers--;
}

Console.Write(countOfPositiveNumbers);