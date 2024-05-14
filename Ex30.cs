string hexval = "4B0";

Console.WriteLine("Hexadecimal number: " + hexval);

var decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

Console.WriteLine("Decimal number: " + decValue);