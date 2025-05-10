// See https://aka.ms/new-console-template for more information

int tax = int.Parse(Console.ReadLine()!);

double shoesPrice = tax - (tax * 0.4);
double jerseyPrice = shoesPrice - (shoesPrice * 0.2);
double ballPrice = jerseyPrice / 4;
double accessoriesPrice = ballPrice / 5;

double totalPrice = tax + shoesPrice + jerseyPrice + ballPrice + accessoriesPrice;

Console.WriteLine(totalPrice);