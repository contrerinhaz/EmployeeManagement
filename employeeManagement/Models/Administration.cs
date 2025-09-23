namespace employeeManagement.Models;

public static class Administration
{
   public static Employee CreateEmployee()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine() ?? "";
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine() ?? "";
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Identification Number: ");
        string id = Console.ReadLine() ?? "";
        Console.Write("Position: ");
        string position = Console.ReadLine() ?? "";
        Console.Write("Salary: ");
        decimal salary = decimal.Parse(Console.ReadLine() ?? "0");

        return new Employee(firstName, lastName, age, id, position, salary);
    }

    
    public static Client CreateClient()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine() ?? "";
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine() ?? "";
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Email: ");
        string email = Console.ReadLine() ?? "";
        Console.Write("Phone: ");
        string phone = Console.ReadLine() ?? "";

        return new Client(firstName, lastName, age, email, phone);
    }

  public static void ShowTitle(string title)
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine($"   {title.ToUpper()}");
        Console.WriteLine("=================================\n");
    }

    public static void ShowFooter(string footer)
    {
        Console.WriteLine("\n=================================");
        Console.WriteLine(footer);
        Console.WriteLine("=================================\n");
    }

    public static void ShowSeparator()
    {
        Console.WriteLine("---------------------------------");
    }
}
