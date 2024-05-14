Console.WriteLine("Input an integer:"); 
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20);