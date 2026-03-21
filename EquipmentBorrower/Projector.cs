namespace EquipmentBorrower;

public class Projector(string brand, float weight, string color, float imageResolution)
    : Equipment(brand, weight, color)
{
    private float ImageResolution { get; } = imageResolution;
}