namespace EquipmentBorrower;

public class UserService
{
    private readonly UserRepository UserRepository = new();

    public void AddUser(User user)
    {
        UserRepository.Save(user);
    }
}