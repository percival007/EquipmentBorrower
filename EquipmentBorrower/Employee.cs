namespace EquipmentBorrower;

public class Employee(string firstName, string lastName, string department) : User(firstName, lastName)
{
    private string Department { get; } = department;

    public override string ToString()
    {
        return
            $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, TotalPenalty: {TotalPenalty}, Department: {Department}";
    }
}