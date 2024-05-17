namespace OOP_TX2_2.Entities;

public class Customer : Person
{
    public int Balance { get; set; }

    public override void Display() =>
        Console.WriteLine($"Customer (Name: {Name}, Address: {Address}, Balance: {Balance})");
}