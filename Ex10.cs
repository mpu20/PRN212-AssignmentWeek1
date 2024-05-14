Console.Write("Enter the First number: ");
var number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Second number: ");
var number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number: ");
var number3 = Convert.ToDouble(Console.ReadLine());

Console.Write(
    $"Result of specified numbers {number1}, {number2} and {number3}, (x+y)•z is {(number1 + number2) * number3} and x•y + y•z is {number1 * number2 + number2 * number3}");