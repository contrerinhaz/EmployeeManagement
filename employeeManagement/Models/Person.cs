namespace employeeManagement.Models;

public abstract class Person
{
    public Guid Id { get; protected set; }
    protected string FirstName { get; set; }
    protected string LastName { get; set; }
    protected int Age { get; set; }

    protected Person(string firstName, string lastName, int age)
    {
        Id = Guid.NewGuid();
        FirstName = firstName.Trim();
        LastName = lastName.Trim();
        Age = age;
    }

    public abstract void ShowInfo();

    protected string FullName => $"{FirstName} {LastName}";
}