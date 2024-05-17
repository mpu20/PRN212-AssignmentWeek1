using AssignmentOOP.Interfaces;

namespace AssignmentOOP.Entities;

public abstract class Employee : IEmployee
{
    public string Name { get; set; } = string.Empty;
    public int PaymentPerHour { get; set; }

    public abstract int CalculateSalary();
    public string GetName() => Name;

    public new string ToString() => $"Employee (Name: {Name}, PaymentPerHour: {PaymentPerHour})";
}