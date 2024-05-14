Console.WriteLine("\nSum of the first 500 prime numbers: "); 

var sum = 0;
var ctr = 0; 
var n = 2;

while (ctr < 500)
{
    if (IsPrime(n)) 
    {
        sum += n; 
        ctr++; 
    }
    n++;
}

Console.WriteLine(sum);
return;

bool IsPrime(int n)
{
    if (n == 1) return false; 
    if (n == 2) return true;
    
    for (var i = 2; i <= (int)Math.Floor(Math.Sqrt(n)); i++)
    {
        if (n % i == 0) return false;
    }

    return true;
}