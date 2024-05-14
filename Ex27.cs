Console.Write("Input a number(integer): "); 

var n = Convert.ToInt32(Console.ReadLine()); 

var sum = 0; 

while (n != 0) {
    sum += n % 10; 
    n /= 10; 
}

Console.WriteLine("Sum of the digits of the said integer: " + sum);