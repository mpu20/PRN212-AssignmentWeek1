Console.Write("Enter string: ");
var str = Console.ReadLine() ?? string.Empty; 

Console.Write("Enter position you want to remove: ");
var pos = int.Parse(Console.ReadLine() ?? "-1"); 

Console.WriteLine($"String after removing character at position {pos}: {str.Remove(pos, 1)}");