for (var i = 1000; i > 1; i--)
{
    if (IsPrime(i) && IsDescending(i))
    {
        Console.WriteLine(i);
    }
}

return;

bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (var i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}

bool IsDescending(int number)
{
    var digits = number.ToString().ToCharArray();
    Array.Sort(digits);
    Array.Reverse(digits);
    return number.ToString() == new string(digits);
}