// See https://aka.ms/new-console-template for more information

double radians = double.Parse(Console.ReadLine()!);

double degrees = radians * 180 / Math.PI;

Console.WriteLine(degrees);