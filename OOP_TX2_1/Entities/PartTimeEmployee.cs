namespace AssignmentOOP.Entities;

public class PartTimeEmployee : Employee
{
    public int WorkingHours { get; set; }

    public override int CalculateSalary() => WorkingHours * PaymentPerHour;
    
    public new string ToString() => $"Part-time Employee (Name: {Name}, Payment per hour: {PaymentPerHour}, Working hours: {WorkingHours})";
}