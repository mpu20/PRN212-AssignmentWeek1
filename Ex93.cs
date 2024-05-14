var n = 120;
Console.WriteLine("Original number: " + n);

Console.WriteLine("Square root of the said number: " + Test(n));

n = 225;
Console.WriteLine("\nOriginal number: " + n);
Console.WriteLine("Square root of the said number: " + Test(n));

n = 335;
Console.WriteLine("\nOriginal number: " + n);
Console.WriteLine("Square root of the said number: " + Test(n));
return;

int Test(int x)
{
    var result = 0;
    while (result * result <= x)
        result++;
    return result-1;
}