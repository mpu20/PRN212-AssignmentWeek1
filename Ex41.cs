Console.Write("Input a string (contains at least one 'w' char) : ");

var str = Console.ReadLine();

var count = str!.Count(s => s == 'w');

Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");

Console.WriteLine(count is >= 1 and <= 3);