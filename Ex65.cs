int[] nums = { 1, 3, 5, 7, 9 };

Console.WriteLine(nums.Select(el => el * nums.Length).ToArray());