namespace EquipmentBorrower;

public abstract class Equipment(string brand, string color)
{
    protected Guid Id { get; } = Guid.NewGuid();
    protected string Brand { get; } = brand;
    protected string Color { get; } = color;
    public EquipmentStatus Status { get; set; } = EquipmentStatus.Available;
    public List<Rent> Rents { get; } = [];

    public override string ToString()
    {
        return $"Id: {Id}, Brand: {Brand}, Color: {Color}, Status: {Status}";
    }
}