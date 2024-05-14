int[] inputArray = [1, 3, 5, 6, 9];

Array.Sort(inputArray);

var ctr = 0;

for (var i = 0; i < inputArray.Length - 1; i++)
{
    ctr += inputArray[i + 1] - inputArray[i] - 1;
}

Console.WriteLine(ctr);