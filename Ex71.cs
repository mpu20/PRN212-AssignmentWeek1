Console.WriteLine("Original string: PHP");
Console.WriteLine("Test for consecutive similar letters! " + Check("PHP"));

Console.WriteLine("Original string: PHHP");
Console.WriteLine("Test for consecutive similar letters! " + Check("PHHP"));
return;

bool Check(string text)
{
    for (var i = 0; i < text.Length - 1; i++)
    {
        if (text[i] == text[i + 1]) 
        { 
            return true; 
        }
    }

    return false;
}