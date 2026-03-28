namespace EquipmentBorrower;

public class UserRepository
{
    private static readonly List<User> Users = [];

    public User Save(User user)
    {
        Users.Add(user);
        return user;
    }

    public List<User> FindAll()
    {
        return Users;
    }
}