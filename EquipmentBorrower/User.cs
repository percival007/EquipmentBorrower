namespace EquipmentBorrower;

public abstract class User(string firstName, string lastName)
{
    private string FirstName { get; } = firstName;
    private string LastName { get; } = lastName;
}