// See https://aka.ms/new-console-template for more information
int dogPackageCount = int.Parse(Console.ReadLine()!);
int catPackageCount = int.Parse(Console.ReadLine()!);

double dogFoodPrice = 2.50;
double catFoodPrice = 4.00;

double dogFoodTotalPrice = dogPackageCount * dogFoodPrice;
double catFoodTotalPrice = catPackageCount * catFoodPrice;
double totalPrice = dogFoodTotalPrice + catFoodTotalPrice;

Console.WriteLine($"{totalPrice} lv.");