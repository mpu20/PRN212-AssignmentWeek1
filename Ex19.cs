Console.WriteLine("Input first integer:");
var a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer:");
var b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a == b ? (a + b) * 3 : a + b);