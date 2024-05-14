int[][] matrix =
{
    [0, 2, 3, 2],
    [0, 6, 0, 1],
    [4, 0, 3, 0]
};

var sum = 0;

for (var i = 0; i < matrix.Length; i++)
{
    for (var j = 0; j < matrix[i].Length; j++)
    {
        if (i == 0 || matrix[i - 1][j] != 0)
        {
            sum += matrix[i][j];
        }
    }
}

Console.WriteLine(sum);