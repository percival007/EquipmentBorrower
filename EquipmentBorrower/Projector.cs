namespace EquipmentBorrower;

public class Projector(string brand, string color, int lumens, string resolution) : Equipment(brand, color)
{
    private int Lumens { get; } = lumens;
    private string Resolution { get; } = resolution;

    public override string ToString()
    {
        return
            $"Id: {Id}, Brand: {Brand}, Color: {Color}, Status: {Status}, Lumens: {Lumens}, Resolution: {Resolution}";
    }
}