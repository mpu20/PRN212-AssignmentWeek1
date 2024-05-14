using System.Text.RegularExpressions;

var text = "Python";
Console.WriteLine("Original string: " + text);
Console.WriteLine($"After removing all the vowels from the said string: {new Regex(@"[aeiouAEIOU]").Replace(text, "")}");