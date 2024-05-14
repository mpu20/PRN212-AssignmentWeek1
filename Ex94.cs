string[] arr_strings1 = { "Padas", "Packed", "Pace", "Pacha" };
Console.WriteLine("Original strings: " + $"{string.Join(", ", arr_strings1)}");
Console.WriteLine("Longest common prefix from the said array of strings: " + Test(arr_strings1));

string[] arr_strings2 = { "Jacket", "Joint", "Junky", "Jet" };
Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings2)}");
Console.WriteLine("Longest common prefix from the said array of strings: " + Test(arr_strings2));

string[] arr_strings3 = { "Bort", "Whang", "Yarder", "Zoonic" };
Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings3)}");
Console.WriteLine("Longest common prefix from the said array of strings: " + Test(arr_strings3));
return;

string Test(string[] str)
{
    if (str.Length == 0)
        return string.Empty;

    Array.Sort(str);

    var first = str[0];
    var last = str[^1];

    var i = 0;
    while (i < first.Length && i < last.Length && first[i] == last[i])
        i++;

    return first[..i];
}