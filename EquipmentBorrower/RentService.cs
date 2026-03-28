namespace EquipmentBorrower;

public class RentService
{
    private readonly RentRepository RentRepository = new();

    public void Rent(User user, Equipment equipment, DateTime returnDate)
    {
        if (equipment.Status != EquipmentStatus.Available)
        {
            throw new InvalidOperationException("Equipment is not available");
        }

        var countRented = user.Rents.Count(r => r.Equipment.Status == EquipmentStatus.Rented);

        if (countRented >= GetMaxRentCount(user))
        {
            throw new InvalidOperationException("Cannot Rent more than 2 equipments");
        }

        equipment.Status = EquipmentStatus.Rented;
        var rent = new Rent(user, equipment, returnDate);
        user.Rents.Add(rent);
        equipment.Rents.Add(rent);
        RentRepository.Save(rent);
    }

    private int GetMaxRentCount(User user)
    {
        return user.GetType() == typeof(Student) ? 2 : 5;
    }

    public void Return(User user, Equipment equipment, DateTime returnDate)
    {
        var rent = user.Rents.First(r => r.Equipment == equipment && r.Equipment.Status == EquipmentStatus.Rented);
        if (rent.DueDate < returnDate)
        {
            user.TotalPenalty += 20;
        }

        rent.ReturnDate = returnDate;
        equipment.Status = EquipmentStatus.Available;
        user.Rents.Remove(rent);
        equipment.Rents.Remove(rent);
    }

    public List<Rent> GetAllLateReturnedRents()
    {
        return RentRepository.FindAll().Where(r => r.DueDate < r.ReturnDate).ToList();
    }

    public List<Rent> GetActiveRents(User user)
    {
        return user.Rents.Where(r => r.ReturnDate == null).ToList();
    }

    public String GetReport()
    {
        var rents = RentRepository.FindAll();
        var activeRents = rents.Count(r => r.ReturnDate == null);
        return $"Number of all rents: {rents.Count}, Active rents: {activeRents}";
    }
}