Console.WriteLine("\nInput first integer:");

var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer:");

var y = Convert.ToInt32(Console.ReadLine());

var n = 20;

var val1 = Math.Abs(x - n);

var val2 = Math.Abs(y - n);

Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));