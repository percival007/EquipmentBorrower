using EquipmentBorrower;

public class Program
{
    public static void Main()
    {
        var userService = new UserService();
        var equipmentService = new EquipmentService();
        var rentService = new RentService();
        
        var laptop1 = new Laptop("Lenovo", "Black", 32, "i7");
        equipmentService.AddEquipment(laptop1);

        var camera1 = new Camera("Canon", "Black", 7, true);
        equipmentService.AddEquipment(camera1);

        var projector1 = new Projector("Cosmo", "White", 10000, "1080x1600");
        equipmentService.AddEquipment(projector1);
        
        var projector2 = new Projector("Xiaomi", "Red", 8000, "1080x1600");
        equipmentService.AddEquipment(projector2);

        var student1 = new Student("Jan", "Markowski", "s12345");
        userService.AddUser(student1);

        var student2 = new Student("Karol", "Kowalski", "s43534");
        userService.AddUser(student2);

        var employee1 = new Employee("Mateusz", "Kolowy", "IT");
        userService.AddUser(employee1);

        var employee2 = new Employee("Paweł", "Kowalski", "Architecture");
        userService.AddUser(employee2);
        
        rentService.Rent(student2, projector2, new DateTime(2026, 3, 21));
        
        rentService.Rent(student1, camera1, new DateTime(2026, 3, 21));
        rentService.Rent(student1, projector1, new DateTime(2026, 3, 21));
        try
        {
            rentService.Rent(student1, laptop1, new DateTime(2026, 3, 21));
        }
        catch (Exception e)
        {
            Console.WriteLine($"Wystąpił problem: {e.Message}");
        }

        rentService.Return(student1, camera1, new DateTime(2026, 3, 22));
        Console.WriteLine($"Użytkownik dostał karę bo nie oddał w terminie: {student1.TotalPenalty}");
        
        rentService.Return(student2, projector2, new DateTime(2026, 3, 20));
        Console.WriteLine($"Użytkownik nie dostał kary bo oddał w terminie: {student2.TotalPenalty}");

        Console.WriteLine($"Report: {rentService.GetReport()}");
    }
}