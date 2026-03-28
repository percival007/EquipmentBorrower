namespace EquipmentBorrower;

public class EquipmentRepository
{
    private static readonly List<Equipment> Equipments = [];

    public List<Equipment> FindAll()
    {
        return Equipments;
    }

    public Equipment Save(Equipment equipment)
    {
        Equipments.Add(equipment);
        return equipment;
    }
}