int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};

Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));

int[] nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};

Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));

Console.WriteLine("\nCheck if the first element or the last element of the two arrays (length 1 or more) are equal.");

Console.WriteLine(nums1[0] == nums2[0] || nums1[^1] == nums2[^1]);