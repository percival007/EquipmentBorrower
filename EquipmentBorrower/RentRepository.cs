namespace EquipmentBorrower;

public class RentRepository
{
    private static readonly List<Rent> Rents = [];

    public List<Rent> FindAll()
    {
        return Rents;
    }

    public Rent Save(Rent rent)
    {
        Rents.Add(rent);
        return rent;
    }
}