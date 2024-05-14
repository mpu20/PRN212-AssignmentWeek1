var text = "Python 3.0";

Console.WriteLine("Original string:: " + text);

var ctrLetters = text.Count(char.IsLetter);

var ctrDigits = text.Count(char.IsDigit);

Console.Write("Number of letters: " + ctrLetters + "  Number of digits: " + ctrDigits);