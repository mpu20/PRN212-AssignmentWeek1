var str = "Python";
Console.WriteLine("Original string: " + str);

var result = str.Select((x, i) => i).Where(i => char.IsLower(str[i])).ToArray();

Console.WriteLine("\nIndices of all lower case letters of the said string:");
foreach (var item in result)
{
    Console.Write(item + " ");
}