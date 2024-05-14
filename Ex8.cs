Console.WriteLine("Enter a number:");
var x = Convert.ToInt32(Console.ReadLine());
for (var factor = 1; factor <= 10; factor++)
    Console.WriteLine($"The table is : {x} x {factor} = {x*factor}");