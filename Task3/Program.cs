Console.WriteLine("Write a number: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number % 2 == 0 ) 
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}