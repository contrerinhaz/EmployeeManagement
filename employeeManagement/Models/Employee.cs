using System;

namespace employeeManagement.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentifiyNumber { get; set; }
    public byte Age { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string identifiyNumber, byte age, string position, double salary)
    {
        Id = Guid.NewGuid();
        FirstName = firstName.Trim();
        LastName = lastName.Trim();
        IdentifiyNumber = identifiyNumber.Trim();
        Age = age;
        Position = position.Trim();
        Salary = salary;
    }

    private double CalculateBonus() => Salary * 0.10;

    public void ShowInfo()
    {
        double salaryWithBonus = Salary + CalculateBonus();
        Console.WriteLine($"Empleado: {FirstName} {LastName}, Edad: {Age}, Cargo: {Position}, Salario con bonificación: {salaryWithBonus:C}");
    }
}