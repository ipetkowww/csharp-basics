// See https://aka.ms/new-console-template for more information

int pencilPacks = int.Parse(Console.ReadLine()!);
int markerPacks = int.Parse(Console.ReadLine()!);
int detergentLiters = int.Parse(Console.ReadLine()!);
int discount = int.Parse(Console.ReadLine()!);

double pencilPackPrice = 5.80;
double markerPackPrice = 7.20;
double detergentLiterPrice = 1.20;

double totalPrice = (pencilPacks * pencilPackPrice) + (markerPacks * markerPackPrice) +
                    (detergentLiters * detergentLiterPrice);
                    
double priceAfterDiscount = totalPrice - (totalPrice * discount / 100);

Console.WriteLine(priceAfterDiscount);