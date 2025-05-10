// See https://aka.ms/new-console-template for more information

int plastic = int.Parse(Console.ReadLine()!);
int paint = int.Parse(Console.ReadLine()!);
int thinner = int.Parse(Console.ReadLine()!);
int hours = int.Parse(Console.ReadLine()!);

double plasticPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;

double plasticTotal = (plastic + 2) * plasticPrice;
double paintTotal = (paint + (paint * 0.10)) * paintPrice;
double thinnerTotal = thinner * thinnerPrice;
double bagTotal = 0.4;

double total = plasticTotal + paintTotal + thinnerTotal + bagTotal;
double sumForMaster = total * 0.30 * hours;
double totalSum = total + sumForMaster;

Console.WriteLine(totalSum);