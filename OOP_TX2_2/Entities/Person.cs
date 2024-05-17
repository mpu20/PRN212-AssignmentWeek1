namespace OOP_TX2_2.Entities;

public abstract class Person
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    public abstract void Display();
}