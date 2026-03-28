namespace EquipmentBorrower;

public abstract class User(string firstName, string lastName)
{
    protected Guid Id { get; } = Guid.NewGuid();
    protected string FirstName { get; } = firstName;
    protected string LastName { get; } = lastName;
    public List<Rent> Rents { get; } = [];
    public decimal TotalPenalty { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, TotalPenalty: {TotalPenalty}";
    }
}