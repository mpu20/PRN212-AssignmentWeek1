Console.Write("Input a string: ");

var str = Console.ReadLine()!;

for (var i = 0; i < str.Length; i += 2)
    Console.Write(str[i]);
Console.WriteLine();