namespace employeeManagement.Models;

public class Companys
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Employee> Employees { get; private set; }
    public List<Client> Clients { get; private set; }

    public Companys(string name, string address)
    {
        Name = name.Trim();
        Address = address.Trim();
        Employees = new List<Employee>();
        Clients = new List<Client>();
    }


    public void AddEmployee(Employee employee) => Employees.Add(employee);

    public bool RemoveEmployee(string identificationNumber)
    {
        var employee = Employees.FirstOrDefault(e => e.IdentificationNumber == identificationNumber);
        if (employee != null)
        {
            Employees.Remove(employee);
            return true;
        }
        return false;
    }

    public void ShowAllEmployees()
    {
        if (!Employees.Any())
        {
            Console.WriteLine("No employees registered.");
            return;
        }

        foreach (var emp in Employees)
            emp.ShowInfo();
    }

  
    public void AddClient(Client client) => Clients.Add(client);

    public bool RemoveClient(string firstName, string lastName)
    {
        var client = Clients.FirstOrDefault(c =>
            c.GetType().GetProperty("FirstName")!.GetValue(c)?.ToString()?.Equals(firstName, StringComparison.OrdinalIgnoreCase) == true &&
            c.GetType().GetProperty("LastName")!.GetValue(c)?.ToString()?.Equals(lastName, StringComparison.OrdinalIgnoreCase) == true);

        if (client != null)
        {
            Clients.Remove(client);
            return true;
        }
        return false;
    }

    public void ShowAllClients()
    {
        if (!Clients.Any())
        {
            Console.WriteLine("No clients registered.");
            return;
        }

        foreach (var client in Clients)
            client.ShowInfo();
    }
}
