object[] mixedArray = new object[6];
mixedArray[0] = 25;
mixedArray[1] = "Anna";
mixedArray[2] = false;
mixedArray[3] = DateTime.Now;
mixedArray[4] = -112;
mixedArray[5] = -34.67;

Console.WriteLine("Original array elements:");
Console.WriteLine(string.Join(", ", mixedArray));

Console.WriteLine("\nAfter removing all the values except integer values from the said array of mixed values:");
Console.WriteLine(string.Join(", ", mixedArray.OfType<int>()));
