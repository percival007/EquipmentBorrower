namespace EquipmentBorrower;

public class Laptop(string brand, string color, int ramGb, string cpu) : Equipment(brand, color)
{
    private int RamGb { get; } = ramGb;
    private string Cpu { get; } = cpu;

    public override string ToString()
    {
        return $"Id: {Id}, Brand: {Brand}, Color: {Color}, Status: {Status}, RamGb: {RamGb}, Cpu: {Cpu}";
    }
}