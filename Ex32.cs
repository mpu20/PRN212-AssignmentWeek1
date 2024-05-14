Console.Write("Input a string: ");
var str = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"\n{(str.Length < 4 ? str : Enumerable.Repeat(str.Substring(str.Length - 4), 4))}");