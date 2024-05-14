int n = 120;
Console.WriteLine("Original number: " + n);

Console.WriteLine("Next prime number/Current prime number: " + Test(n));

n = 321;
Console.WriteLine("\nOriginal number: " + n);
Console.WriteLine("Next prime number/Current prime number: " + Test(n));

n = 43;
Console.WriteLine("\nOriginal number: " + n);
Console.WriteLine("Next prime number/Current prime number: " + Test(n));

n = 4433;
Console.WriteLine("\nOriginal number: " + n);
Console.WriteLine("Next prime number/Current prime number: " + Test(n));
return;

int Test(int n)
{
    for (var i = 2; i < n; i++)
    {
        if (n % i != 0) continue;
        n++;
        i = 2;
    }
    return n;
}