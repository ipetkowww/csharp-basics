// See https://aka.ms/new-console-template for more information

decimal usd = decimal.Parse(Console.ReadLine()!);
decimal usdToBgn = 1.79549m;

decimal bgn = usd * usdToBgn;
Console.WriteLine(bgn);