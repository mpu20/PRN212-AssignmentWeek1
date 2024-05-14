Console.WriteLine("Input an integer value:");

var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Check whether the said value is greater than its swap value: {n / 10 > n % 10}");