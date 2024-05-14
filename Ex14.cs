Console.Write("Enter the amount of Celsius: "); 
var celsius = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Kelvin = {0}", celsius + 273);

Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);