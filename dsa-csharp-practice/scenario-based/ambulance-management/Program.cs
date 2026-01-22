class Program
{
    static void Main()
    {
        AmbulanceRoute route = new AmbulanceRoute();

        route.AddHospitalUnit("Emergency", false);
        route.AddHospitalUnit("Radiology", false);
        route.AddHospitalUnit("Surgery", true);
        route.AddHospitalUnit("ICU", false);

        route.DisplayUnits();

        Console.WriteLine("\nAmbulance Arrives:");
        route.FindNearestAvailableUnit();

        route.RemoveHospitalUnit("Surgery");

        Console.WriteLine("\nNext Patient Arrives:");
        route.FindNearestAvailableUnit();
    }
}
