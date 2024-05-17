namespace AssignmentOOP.Entities;

public class FullTimeEmployee : Employee
{
    public override int CalculateSalary() => 8 * PaymentPerHour;

    public new string ToString() => $"Full-time Employee (Name: {Name}, PaymentPerHour: {PaymentPerHour})";
}