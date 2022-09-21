Console.WriteLine("Write a number: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int count = 1;

while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count ++;
}