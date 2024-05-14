Console.Write("Enter string: ");
var str = Console.ReadLine() ?? string.Empty; 

Console.WriteLine(str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str);