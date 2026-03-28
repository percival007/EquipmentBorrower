namespace EquipmentBorrower;

public class UserService
{
    private readonly UserRepository _userRepository = new();

    public void AddUser(User user)
    {
        _userRepository.Save(user);
    }
}