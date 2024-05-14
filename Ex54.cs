Console.Write("Enter year: ");

var year = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Century: {(year - 1) / 100 + 1}");