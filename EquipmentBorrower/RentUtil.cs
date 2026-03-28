namespace EquipmentBorrower;

public class RentUtil
{
    private const int StudentLimit = 2;
    private const int EmployeeLimit = 5;
    
    public static int GetMaxRentCount(User user)
    {
        return user.GetType() == typeof(Student) ? StudentLimit : EmployeeLimit;
    }
    
}