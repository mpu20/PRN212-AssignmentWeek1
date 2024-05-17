namespace OOP_TX2_2.Entities;

public class Employee : Person
{
    public int Salary { get; set; }

    public override void Display() =>
        Console.WriteLine($"Employee (Name: {Name}, Address: {Address}, Salary: {Salary})");
}