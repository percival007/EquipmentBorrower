namespace EquipmentBorrower;

public class Laptop(string brand, float weight, string color, float screenResolution) : Equipment(brand, weight, color)
{

    private float ScreenResolution { get; } = screenResolution;
    
}