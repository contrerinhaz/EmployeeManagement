using System;
using System.Collections.Generic;
using System.Linq;

namespace employeeManagement.Models;

public class Companys
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Employee> Employees { get; set; }

    public Companys(string name, string address)
    {
        Name = name.Trim();
        Address = address.Trim();
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee) => Employees.Add(employee);

    public bool RemoveEmployee(string firstName, string lastName)
    {
        var employee = Employees.FirstOrDefault(e =>
            e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
            e.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

        if (employee != null)
        {
            Employees.Remove(employee);
            return true;
        }
        return false;
    }

    public Employee? SearchEmployee(string identifiyNumber ) =>
        Employees.FirstOrDefault(e => e.IdentifiyNumber  == identifiyNumber );

    public void ShowEmployeesByPosition(string position)
    {
        var filtered = Employees
            .Where(e => e.Position.Equals(position, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (!filtered.Any())
        {
            Console.WriteLine($"No hay empleados con el cargo {position}");
            return;
        }

        foreach (var emp in filtered)
            emp.ShowInfo();
    }

    public void ShowAllEmployees()
    {
        if (!Employees.Any())
        {
            Console.WriteLine("No employees were registered.");
            return;
        }

        foreach (var emp in Employees)
            emp.ShowInfo();
    }
}