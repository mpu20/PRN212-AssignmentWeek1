Console.WriteLine("Input first integer:");
var a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer:");
var b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine((a - b) * 2);
}
Console.WriteLine(b - a);