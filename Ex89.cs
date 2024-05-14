int[] nums = [10, -11, 12, -13, 14, -18, 19, -20];

Console.WriteLine("Original Array elements:" + string.Join(", ", nums));

var pos = nums.Where(n => n > 0);
var neg = nums.Where(n => n < 0);

Console.WriteLine("Number of positive numbers: " + pos.Count() + "\nNumber of negative numbers: " + neg.Count());
