// See https://aka.ms/new-console-template for more information

double deposit = double.Parse(Console.ReadLine()!);
int period = int.Parse(Console.ReadLine()!);
double interestRate = double.Parse(Console.ReadLine()!) / 100;

double sum = deposit + period * (((deposit * (interestRate)) / 12) * 1.0);

Console.WriteLine(sum);