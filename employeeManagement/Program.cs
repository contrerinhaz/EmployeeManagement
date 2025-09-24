using employeeManagement.Models;

namespace employeeManagement;

class Program
{
    static void Main(string[] args)
    {
        Companys company = new Companys("TechCorp", "Main Street 123");
        bool running = true;

        while (running)
        {
            Administration.ShowTitle("Company Management Menu");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Remove Employee (by ID)");
            Console.WriteLine("3. Show All Employees");
            Console.WriteLine("4. Add Client");
            Console.WriteLine("5. Remove Client (by Name)");
            Console.WriteLine("6. Show All Clients");
            Console.WriteLine("0. Exit");
            Administration.ShowSeparator();
            Console.Write("Select an option: ");

            string? choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    var emp = Administration.CreateEmployee();
                    company.AddEmployee(emp);
                    Console.WriteLine("Employee added successfully.");
                    break;

                case "2":
                    Console.Write("Identification Number: ");
                    string id = Console.ReadLine() ?? "";
                    bool removed = company.RemoveEmployee(id);
                    Console.WriteLine(removed ? "Employee removed." : "Employee not found.");
                    break;

                case "3":
                    company.ShowAllEmployees();
                    break;

                case "4":
                    var client = Administration.CreateClient();
                    company.AddClient(client);
                    Console.WriteLine("Client added successfully.");
                    break;

                case "5":
                    Console.Write("First Name: ");
                    string fn = Console.ReadLine() ?? "";
                    Console.Write("Last Name: ");
                    string ln = Console.ReadLine() ?? "";
                    bool clientRemoved = company.RemoveClient(fn, ln);
                    Console.WriteLine(clientRemoved ? "Client removed." : "Client not found.");
                    break;

                case "6":
                    company.ShowAllClients();
                    break;

                case "0":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
