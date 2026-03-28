namespace EquipmentBorrower;

public class Camera(string brand, string color, int megaPixels, bool isDigital) : Equipment(brand, color)
{
    private int Megapixels { get; } = megaPixels;
    private bool IsDigital { get; } = isDigital;

    public override string ToString()
    {
        return
            $"Id: {Id}, Brand: {Brand}, Color: {Color}, Status: {Status}, Megapixels: {Megapixels}, IsDigital: {IsDigital}";
    }
}