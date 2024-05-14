var str = "PHP Tutorial";

Console.WriteLine(str.IndexOf("HP", StringComparison.Ordinal) == 1 ? str.Remove(1, 2) : str);
