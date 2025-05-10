// See https://aka.ms/new-console-template for more information

int length = int.Parse(Console.ReadLine()!);
int width = int.Parse(Console.ReadLine()!);
int height = int.Parse(Console.ReadLine()!);
double percent = double.Parse(Console.ReadLine()!) / 100;

double volume = length * width * height;
double volumeInLiters = volume / 1000;
double needLiters = volumeInLiters * (1 - percent);

Console.WriteLine(needLiters);