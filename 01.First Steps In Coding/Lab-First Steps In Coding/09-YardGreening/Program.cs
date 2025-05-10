// See https://aka.ms/new-console-template for more information

double area = double.Parse(Console.ReadLine()!);

double pricePerSquareMeter = 7.61;
double discount = 0.18;

double totalPrice = area * pricePerSquareMeter;
double discountAmount = totalPrice * discount;
double finalPrice = totalPrice - discountAmount;

Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discountAmount} lv.");