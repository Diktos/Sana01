using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double m, n, x, a, b;
double z1, z2, y;


Console.Write("Введіть a: ");
while (!double.TryParse(Console.ReadLine(), out a))
{
    Console.Write("Помилка! Введіть коректне число a: ");
}

Console.Write("Введіть b: ");
while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.Write("Помилка! Введіть коректне число b: ");
}

Console.Write("Введіть m: ");
while (!double.TryParse(Console.ReadLine(), out m))
{
    Console.Write("Помилка! Введіть коректне число m: ");
}

Console.Write("Введіть n: ");
while (!double.TryParse(Console.ReadLine(), out n))
{
    Console.Write("Помилка! Введіть коректне число n: ");
}

Console.Write("Введіть x: ");
while (!double.TryParse(Console.ReadLine(), out x))
{
    Console.Write("Помилка! Введіть коректне число x: ");
}

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
     (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;


y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a)
    + (a - b) * Math.Pow(Math.Sin(a - b), 2)
    + Math.Pow(10.0, -2.0) * (x - b);


Console.WriteLine("\nРезультати:");
Console.WriteLine($"z1 = {z1}");
Console.WriteLine($"z2 = {z2}");
Console.WriteLine($"y  = {y}");


