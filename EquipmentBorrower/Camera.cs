namespace EquipmentBorrower;

public class Camera(string brand, float weight, string color, float videoResolution) : Equipment(brand, weight, color)
{
    
    private float VideoResolution { get; } = videoResolution;
    
}