Console.WriteLine("Input number of straight lines of the polygon:");

var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of the interior angles (in degrees) of the said polygon: {180 * (n - 2)}");