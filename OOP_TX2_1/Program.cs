using AssignmentOOP.Entities;

var employees = new List<Employee>
{
    new FullTimeEmployee()
    {
        Name = "John Doe",
        PaymentPerHour = 1000
    },
    new FullTimeEmployee()
    {
        Name = "Jane Doe",
        PaymentPerHour = 1500
    },
    new PartTimeEmployee()
    {
        Name = "Alex Nguyen",
        PaymentPerHour = 500,
        WorkingHours = 3
    },
    new PartTimeEmployee()
    {
        Name = "Peter Griffin",
        PaymentPerHour = 100,
        WorkingHours = 10
    }
};

ShowMenu();
return;

void ShowMenu()
{
    Console.WriteLine("\n------Menu------");
    Console.WriteLine("1. Find full-time and part-time employees having highest salary");
    Console.WriteLine("2. Find employees by name");
    Console.WriteLine("3. Exit");
    Console.Write("Please choose one option: ");

    GetOption();
}

void GetOption()
{
    var option = int.Parse(Console.ReadLine() ?? "0");

    switch (option)
    {
        case 1:
            FindEmployeesHavingHighestSalary();
            break;
        case 2:
            FindEmployeesByName();
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Invalid option. Please choose one of the options below.");
            ShowMenu();
            break;
    }
}

void FindEmployeesHavingHighestSalary()
{
    Console.WriteLine();
    Console.WriteLine($"Full-time employee having highest salary: {employees.Where(e => e is FullTimeEmployee).OrderByDescending(e => e.CalculateSalary()).First().Name}");
    Console.WriteLine($"Part-time employee having highest salary: {employees.Where(e => e is PartTimeEmployee).OrderByDescending(e => e.CalculateSalary()).First().Name}");
    Console.Write("Press any key to go back to menu.");
    Console.ReadLine();

    ShowMenu();
}

void FindEmployeesByName()
{
    Console.Write("\nEnter employee name: ");
    var name = Console.ReadLine()?.Trim().ToLower();
    
    // Find employees having name contains the input name
    var employeesByName = string.IsNullOrEmpty(name)
        ? employees
        : employees.Where(e => e.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase)).ToList();

    // Display the result
    if (employeesByName.Count == 0)
        Console.WriteLine("Employee not found.");
    else
    {
        Console.WriteLine("Employee(s) found:");
        
        foreach (var employee in employeesByName)
        {
            Console.WriteLine(employee.GetType() == typeof(PartTimeEmployee)
                ? (employee as PartTimeEmployee)!.ToString()
                : (employee as FullTimeEmployee)!.ToString());
        }
    }

    Console.Write("Press any key to go back to menu.");
    Console.ReadLine();
    
    ShowMenu();
}