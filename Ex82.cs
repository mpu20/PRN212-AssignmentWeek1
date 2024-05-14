var text = "Py@th12on";
Console.WriteLine("Original string: " + text);
Console.WriteLine($"Remove all characters from the said string which are non-letters: {string.Concat(text.Where(char.IsLetter))}");