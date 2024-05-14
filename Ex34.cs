Console.Write("Input a string : ");
var str = Console.ReadLine() ?? string.Empty;

Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));