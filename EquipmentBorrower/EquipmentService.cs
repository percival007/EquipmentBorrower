namespace EquipmentBorrower;

public class EquipmentService
{
    private readonly EquipmentRepository _equipmentRepository = new();

    public void AddEquipment(Equipment equipment)
    {
        _equipmentRepository.Save(equipment);
    }

    public List<Equipment> GetEquipments()
    {
        return _equipmentRepository.FindAll();
    }

    public List<Equipment> GetAvailableEquipments()
    {
        return _equipmentRepository.FindAll().Where(r => r.Status == EquipmentStatus.Available).ToList();
    }

    public void ServiceEquipment(Equipment equipment)
    {
        equipment.Status = EquipmentStatus.InService;
    }
}