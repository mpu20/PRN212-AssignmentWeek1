var text = "aaa";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Check whether all the characters in the said string are same or not! " + Test(text));

text = "abcd";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Check whether all the characters in the said string are same or not! " + Test(text));

text = "3333";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Check whether all the characters in the said string are same or not! " + Test(text));

text = "2342342";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Check whether all the characters in the said string are same or not! " + Test(text));
return;

bool Test(string str)
{
    if (string.IsNullOrEmpty(str))
        return true;

    var firstChar = str[0];

    return str.All(c => c == firstChar);
}