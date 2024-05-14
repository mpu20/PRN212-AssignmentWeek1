Console.Write("\nInput the First Number : ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("\nInput the Second Number : ");
int number2 = int.Parse(Console.ReadLine());

number1 += number2;
number2 = number1 - number2;
number1 -= number2;

Console.Write("\nAfter Swapping : ");
Console.Write("\nFirst Number : " + number1);
Console.Write("\nSecond Number : " + number2);