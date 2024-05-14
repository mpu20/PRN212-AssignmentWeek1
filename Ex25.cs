Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line."); 

for (var n = 1; n <= 99; n++)
{
    if (n % 2 != 0) 
    {
        Console.WriteLine(n); 
    }
}