namespace employeeManagement.Models;

public class Client : Person
{
    public string Email { get; private set; }
    public string Phone { get; private set; }

    public Client(string firstName, string lastName, int age, string email, string phone)
        : base(firstName, lastName, age)
    {
        Email = email.Trim();
        Phone = phone.Trim();
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Client: {FullName}, Age: {Age}, Email: {Email}, Phone: {Phone}");
    }
}