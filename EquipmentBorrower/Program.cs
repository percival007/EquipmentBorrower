using EquipmentBorrower;

public class Program
{
    public static void Main()
    {
        var userService = new UserService();
        var equipmentService = new EquipmentService();
        var rentService = new RentService();

        var student1 = new Student("Jan", "Markowski", "s12345");
        userService.AddUser(student1);

        var student2 = new Student("Karol", "Kowalski", "s43534");
        userService.AddUser(student2);

        var employee1 = new Employee("Mateusz", "Kolowy", "IT");
        userService.AddUser(employee1);

        var employee2 = new Employee("Paweł", "Kowalski", "Architecture");
        userService.AddUser(employee2);

        var laptop1 = new Laptop("Lenovo", "Black", 32, "i7");
        equipmentService.AddEquipment(laptop1);

        var camera1 = new Camera("Canon", "Black", 7, true);
        equipmentService.AddEquipment(camera1);

        var projector1 = new Projector("Cosmo", "White", 10000, "1080x1600");
        equipmentService.AddEquipment(projector1);

        Console.WriteLine("===== EQUIPMENTS =====");
        equipmentService.GetEquipments().ForEach(Console.WriteLine);

        rentService.Rent(student1, camera1, new DateTime(2026, 3, 21));
        rentService.Rent(student1, laptop1, new DateTime(2026, 3, 21));

        Console.WriteLine("===== ACTIVE RENTS =====");
        rentService.GetActiveRents(student1).ForEach(Console.WriteLine);

        Console.WriteLine("===== EQUIPMENTS AFTER RENT =====");
        equipmentService.GetEquipments().ForEach(Console.WriteLine);

        rentService.Return(student1, camera1, new DateTime(2026, 3, 22));
        Console.WriteLine("===== EQUIPMENTS AFTER LATE RETURN =====");
        equipmentService.GetEquipments().ForEach(Console.WriteLine);

        Console.WriteLine("===== LATE RETURN RENTS =====");
        rentService.GetAllLateReturnedRents().ForEach(Console.WriteLine);

        Console.WriteLine("===== AVAILABLE EQUIPMENTS =====");
        equipmentService.GetAvailableEquipments().ForEach(Console.WriteLine);

        equipmentService.ServiceEquipment(projector1);

        Console.WriteLine($"Report: {rentService.GetReport()}");
    }
}