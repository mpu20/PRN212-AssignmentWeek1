Console.Write("Input a first number: ");
var m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(m is >= -10 and <= 10 || n is >= -10 and <= 10);