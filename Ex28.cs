Console.Write("Original String: ");
var str = Console.ReadLine() ?? string.Empty;

var words = str.Split(" ");

Console.Write($"\nReverse String: {string.Join(" ", words.Reverse())}");


