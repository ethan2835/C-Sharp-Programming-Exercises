namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first altitude");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second altitude");
            int secondAltitude = int.Parse(Console.ReadLine());
            int altitudeChange = secondAltitude - firstAltitude;
            Console.WriteLine($"The change is: {altitudeChange}");
        }
    }
}
