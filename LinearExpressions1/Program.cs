using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double a, b, c, d;
double x, y, z, r;


Console.Write("Введіть число a: ");

while (!double.TryParse(Console.ReadLine(), out a))
{
    Console.Write("Помилка! Введіть коректне число a: ");
}

Console.Write("Введіть число b: ");
while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.Write("Помилка! Введіть коректне число b: ");
}

Console.Write("Введіть число c: ");
while (!double.TryParse(Console.ReadLine(), out c))
{
    Console.Write("Помилка! Введіть коректне число c: ");
}

Console.Write("Введіть число d: ");
while (!double.TryParse(Console.ReadLine(), out d))
{
    Console.Write("Помилка! Введіть коректне число d: ");
}

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) + Math.Pow(a, 2) / Math.Pow(b, 2);

y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);

z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);

r = ((0.5 * a + 0.75 * b - 7.0 / 5.0) / (3 * c + 1)) + 1 / (a - c);

Console.WriteLine("\nРезультати обчислень:");
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"z = {z}");
Console.WriteLine($"r = {r}");