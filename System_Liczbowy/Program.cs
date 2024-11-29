namespace System_Liczbowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SystemLiczbowy systemLiczbowy = new SystemLiczbowy();
            Console.WriteLine("Podaj liczbe dziesietna");

            systemLiczbowy.Dziesietna = Console.ReadLine();
            Console.WriteLine(systemLiczbowy.ToString());
        }
    }
}
