object[] mixedArray = new object[5];
mixedArray[0] = 25; 
mixedArray[1] = "Anna"; 
mixedArray[2] = false; 
mixedArray[3] = DateTime.Now; 
mixedArray[4] = 112.22;

Console.WriteLine("Printing original array elements and their types:");
foreach (var t in mixedArray)
{
    Console.WriteLine("Value-> " + t + " :: Type-> " + t.GetType());
}

var newNums = Array.ConvertAll(mixedArray, x => x.ToString());

Console.WriteLine("\nPrinting array elements and their types after conversion:");
foreach (var t in newNums)
{
    Console.WriteLine("Value-> " + t + " :: Type-> " + t.GetType());
}