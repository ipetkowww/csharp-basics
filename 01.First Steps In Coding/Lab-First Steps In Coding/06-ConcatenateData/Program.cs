// See https://aka.ms/new-console-template for more information
string firstName = Console.ReadLine()!;
string lastName = Console.ReadLine()!;
int age = int.Parse(Console.ReadLine()!);
string town = Console.ReadLine()!;

Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");