string text1 = "AAA";
string text2 = "BBB";
Console.WriteLine("Original values: " + text1 + ", " + text2);
Console.WriteLine("Check the equality of the said values: " + test(text1, text2));

Boolean v1 = true;
Boolean v2 = false;
Console.WriteLine("Original values: " + v1 + ", " + v2);
Console.WriteLine("Check the equality of the said values: " + test(v1, v2));

Boolean v3 = true;
string text3 = "true";
Console.WriteLine("Original values: " + v1 + ", " + text3);
Console.WriteLine("Check the equality of the said values: " + test(v1, text3));

int n1 = 10;
int n2 = 10;
Console.WriteLine("Original values: " + n1 + ", " + n2);
Console.WriteLine("Check the equality of the said values: " + test(n1, n2));

bool test(object x, object y)
{
    if (!x.Equals(y))
    {
        return false;
    }

    if (!x.GetType().Equals(y.GetType()))
    {
        return false;
    }

    return true;
}