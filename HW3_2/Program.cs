Console.Write("Write coordinates for XA: ");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Write coordinates for YA: ");
double ya = double.Parse(Console.ReadLine()!);
Console.Write("Write coordinates for ZA: ");
double za = double.Parse(Console.ReadLine()!);

Console.Write("Write coordinates for XB: ");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Write coordinates for YB: ");
double yb = double.Parse(Console.ReadLine()!);
Console.Write("Write coordinates for ZB: ");
double zb = double.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(xb - xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za,2));
Console.WriteLine(result);