Console.WriteLine("Input a word: ");
var word = Console.ReadLine()!;

Console.WriteLine($"Is '{word}' plural? {word.EndsWith("s")}");