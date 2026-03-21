namespace EquipmentBorrower;

public class Student(string firstName, string lastName, string indexNumber) : User(firstName, lastName)
{
    private string IndexNumber { get; } = indexNumber;
}