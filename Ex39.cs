Console.WriteLine("\nInput first integer:");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer:");
var y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third integer:");
var z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));

Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));