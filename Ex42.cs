Console.Write("Input a string: ");

var str = Console.ReadLine()!;

Console.WriteLine(str.Length < 4 ? str.ToUpper() : string.Concat(str[..4].ToLower(), str.AsSpan(4, str.Length - 4)));
