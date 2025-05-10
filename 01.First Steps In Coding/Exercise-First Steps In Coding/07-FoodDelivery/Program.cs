// See https://aka.ms/new-console-template for more information

int chickenMenus = int.Parse(Console.ReadLine()!);
int fishMenus = int.Parse(Console.ReadLine()!);
int veganMenus = int.Parse(Console.ReadLine()!);

double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double veganMenuPrice = 8.15;
double deliveryPrice = 2.50;

double totalPrice = (chickenMenus * chickenMenuPrice) + (fishMenus * fishMenuPrice) + (veganMenus * veganMenuPrice);
double dessertPrice = totalPrice * 0.20;
double totalSum = totalPrice + dessertPrice + deliveryPrice;

Console.WriteLine(totalSum);