Console.Write("Input a first number(<100): ");
var m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number(>200): ");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(m < 100 && n > 200);