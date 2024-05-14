var str = "50";

Console.WriteLine($"Original value and type: {str}, {str.GetType()}");
Console.WriteLine("Convert string to integer:");
Console.WriteLine($"Return value and type: {int.Parse(str)}, {int.Parse(str).GetType()}");

var num = 123;

Console.WriteLine($"Original value and type: {num}, {num.GetType()}");
Console.WriteLine("Convert integer to string:");
Console.WriteLine($"Return value and type: {num.ToString()}, {num.ToString().GetType()}");