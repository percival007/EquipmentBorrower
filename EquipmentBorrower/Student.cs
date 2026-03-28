namespace EquipmentBorrower;

public class Student(string firstName, string lastName, string indexNumber) : User(firstName, lastName)
{
    private string IndexNumber { get; } = indexNumber;

    public override string ToString()
    {
        return
            $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, TotalPenalty: {TotalPenalty}, IndexNumber: {IndexNumber}";
    }
}