namespace EquipmentBorrower;

public class Rent(User borrower, Equipment equipment, DateTime dueDate)
{
    private User User { get; } = borrower;
    public Equipment Equipment { get; } = equipment;
    public DateTime DueDate { get; } = dueDate;
    private DateTime RentalDate { get; } = DateTime.Now;
    public DateTime? ReturnDate { get; set; }

    public override string ToString()
    {
        return
            $"User: {User}, Equipment: {Equipment}, DueDate: {DueDate}, RentalDate: {RentalDate}, ReturnDate: {ReturnDate}";
    }
}