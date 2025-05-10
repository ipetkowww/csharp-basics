// See https://aka.ms/new-console-template for more information

int pages = int.Parse(Console.ReadLine()!);
int pagesPerHour = int.Parse(Console.ReadLine()!);
int days = int.Parse(Console.ReadLine()!);

int hours = pages / pagesPerHour / days;

Console.WriteLine(hours); 