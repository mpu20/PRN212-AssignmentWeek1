int[] nums = {2, 4, 7, 8, 6};

Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));

Console.WriteLine("Check if an array contains an odd number? " + nums.Any(x => x % 2 != 0));