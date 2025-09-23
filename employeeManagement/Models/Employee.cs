namespace employeeManagement.Models;

public class Employee : Person
{
    public string IdentificationNumber { get; private set; }
    public string Position { get; private set; }
    public decimal Salary { get; private set; }

    public Employee(string firstName, string lastName, int age, string identificationNumber, string position, decimal salary)
        : base(firstName, lastName, age)
    {
        IdentificationNumber = identificationNumber.Trim();
        Position = position.Trim();
        Salary = salary;
    }

    private decimal CalculateBonus() => Salary * 0.10m;

    public override void ShowInfo()
    {
        decimal salaryWithBonus = Salary + CalculateBonus();
        Console.WriteLine($"Employee: {FullName}, Age: {Age}, Position: {Position}, Salary with bonus: {salaryWithBonus:C}");
    }
}