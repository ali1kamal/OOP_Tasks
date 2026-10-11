namespace OOP_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryAddress addresse1 = new DeliveryAddress("Cairo", "Salah Salem", 12);
            DeliveryAddress addresse2 = addresse1;
            addresse2.City = "Shiben Elkom";
            addresse2.Street = "Paris st";
            addresse2.BuildingNumber = 1;
            Console.WriteLine("Original Address: " + addresse1.GetFullAddress());
            Console.WriteLine("Copied Address: " + addresse2.GetFullAddress());
        }
    }
}
