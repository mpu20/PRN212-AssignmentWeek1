int[] nums = {1, 2, 5, 7, 8};

var largest = nums[0] * nums[1];

for (var i = 1; i < nums.Length - 1; i++)
    if (largest < nums[i] * nums[i + 1])
        largest = nums[i] * nums[i + 1];

Console.WriteLine(largest);