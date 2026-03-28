namespace EquipmentBorrower;

public class RentService
{
    private readonly RentRepository _rentRepository = new();
    private readonly UserService _userService = new();

    public void Rent(User user, Equipment equipment, DateTime returnDate)
    {
        ValidateRent(user, equipment);
        equipment.Status = EquipmentStatus.Rented;
        var rent = new Rent(user, equipment, returnDate);
        user.Rents.Add(rent);
        equipment.Rents.Add(rent);
        _rentRepository.Save(rent);
    }

    private static void ValidateRent(User user, Equipment equipment)
    {
        if (equipment.Status != EquipmentStatus.Available)
        {
            throw new InvalidOperationException("Equipment is not available");
        }

        var countRented = user.Rents.Count(r => r.Equipment.Status == EquipmentStatus.Rented);

        if (countRented >= RentUtil.GetMaxRentCount(user))
        {
            throw new InvalidOperationException("Cannot Rent more than 2 equipments");
        }
    }

    public void Return(User user, Equipment equipment, DateTime returnDate)
    {
        var rent = user.Rents.First(r => r.Equipment == equipment && r.Equipment.Status == EquipmentStatus.Rented);
        AddPenaltyOnUser(user, returnDate, rent);

        rent.ReturnDate = returnDate;
        equipment.Status = EquipmentStatus.Available;
        user.Rents.Remove(rent);
        equipment.Rents.Remove(rent);
    }

    private static void AddPenaltyOnUser(User user, DateTime returnDate, Rent rent)
    {
        if (rent.DueDate < returnDate)
        {
            user.TotalPenalty += 20;
        }
    }

    public List<Rent> GetAllLateReturnedRents()
    {
        return _rentRepository.FindAll().Where(r => r.DueDate < r.ReturnDate).ToList();
    }

    public List<Rent> GetActiveRents(User user)
    {
        return user.Rents.Where(r => r.ReturnDate == null).ToList();
    }

    public String GetReport()
    {
        var rents = _rentRepository.FindAll();
        var activeRents = rents.Count(r => r.ReturnDate == null);
        var userCount = _userService.GetAll().Count;
        return $"Number of all rents: {rents.Count}, Active rents: {activeRents}, Registered users: {userCount}";
    }
}