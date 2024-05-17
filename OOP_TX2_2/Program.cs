using OOP_TX2_2.Entities;

var employees = new List<Employee>
{
    new() { Name = "John", Address = "Ha Noi", Salary = 2500 },
    new() { Name = "Jane", Address = "Hung Yen", Salary = 4000 },
    new() { Name = "Jack", Address = "Thai Binh", Salary = 1200 }
};

var customers = new List<Customer>
{
    new() { Name = "Alice", Address = "HCM City", Balance = 1000 },
    new() { Name = "Bob", Address = "Da Nang", Balance = 500 },
    new() { Name = "Charlie", Address = "Quang Ninh", Balance = 300 }
};

ShowMenu();
return;

void ShowMenu()
{
    Console.WriteLine("\n------Menu------");
    Console.WriteLine("1. Find part-time employees having highest salary and customers having lowest balance");
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
            FindHighestSalaryEmployeeAndLowestBalanceCustomer();
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

void FindHighestSalaryEmployeeAndLowestBalanceCustomer()
{
    Console.WriteLine();
    Console.WriteLine($"Employee having highest salary: {employees.OrderByDescending(e => e.Salary).First().Name}");
    Console.WriteLine($"Customer having lowest balance: {customers.OrderBy(c => c.Balance).First().Name}");
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
            employee.Display();
        }
    }

    Console.Write("Press any key to go back to menu.");
    Console.ReadLine();

    ShowMenu();
}