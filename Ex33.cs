Console.WriteLine("\nInput first integer:");

var x = Convert.ToInt32(Console.ReadLine());

if (x > 0) {
    Console.WriteLine(x % 3 == 0 || x % 7 == 0);
}