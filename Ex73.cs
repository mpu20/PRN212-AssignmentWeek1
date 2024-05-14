var str = "PHP";

Console.WriteLine($"Original string: {str}");
Console.WriteLine($"Convert the letters of the said string into alphabetical order: {new string(str.OrderBy(c => c).ToArray())}");

str = "javascript";

Console.WriteLine($"Original string: {str}");
Console.WriteLine($"Convert the letters of the said string into alphabetical order: {new string(str.OrderBy(c => c).ToArray())}");

str = "python";

Console.WriteLine($"Original string: {str}");
Console.WriteLine($"Convert the letters of the said string into alphabetical order: {new string(str.OrderBy(c => c).ToArray())}");