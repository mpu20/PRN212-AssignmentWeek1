Console.Write("Enter string: ");
var str = Console.ReadLine() ?? string.Empty;

var words = str.Split(" ");

var longestWord = string.Empty;

foreach (var word in words)
{
    if (word.Length > longestWord.Length)
    {
        longestWord = word;
    }
}

Console.WriteLine(longestWord);