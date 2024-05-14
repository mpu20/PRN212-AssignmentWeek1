var n = 1234;

Console.WriteLine("\nOriginal number: " + n);

Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");

Console.WriteLine("Number of ones: " + Convert.ToString(n, 2).Count(c => c == '0') + "\nNumber of zeros: " + Convert.ToString(n, 2).Count(c => c == '1'));