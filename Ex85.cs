double[] nums = [1, 3, 4, 5, 6, 7];

Console.WriteLine("\nOriginal Array elements: ");
double sum = 0;

foreach (var item in nums)
{
    Console.Write(sum += item);
}