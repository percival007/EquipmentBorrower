namespace EquipmentBorrower;

public abstract class Equipment(string brand, float weight, string color)
{

    private string Brand { get; } = brand;
    private float Weight { get; } = weight;
    private string Color { get; } = color;
    
}