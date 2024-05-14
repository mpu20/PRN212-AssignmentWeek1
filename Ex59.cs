int[] inputArray = [1, 3, 5, 6, 9];

var ctr = 0;

for (var i = 0; i < inputArray.Length - 1; i++)
{
    if (inputArray[i] >= inputArray[i + 1])
    {
        Console.WriteLine(false);
        return;
    }
        
}

Console.WriteLine(true);