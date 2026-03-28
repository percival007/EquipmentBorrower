namespace EquipmentBorrower;

public class EquipmentService
{
    private readonly EquipmentRepository EquipmentRepository = new();

    public void AddEquipment(Equipment equipment)
    {
        EquipmentRepository.Save(equipment);
    }

    public List<Equipment> GetEquipments()
    {
        return EquipmentRepository.FindAll();
    }

    public List<Equipment> GetAvailableEquipments()
    {
        return EquipmentRepository.FindAll().Where(r => r.Status == EquipmentStatus.Available).ToList();
    }

    public void ServiceEquipment(Equipment equipment)
    {
        equipment.Status = EquipmentStatus.InService;
    }
}