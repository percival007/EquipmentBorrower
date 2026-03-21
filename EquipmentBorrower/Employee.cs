namespace EquipmentBorrower;

public class Employee(string firstName, string lastName, int salary) : User(firstName, lastName)
{
    private int Salary { get; set; } = salary;
}