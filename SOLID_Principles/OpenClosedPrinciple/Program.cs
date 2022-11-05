namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dev = new SoftwareDeveloper();
            Console.WriteLine("Vacation days for developer = " + dev.GetVacationDays());

            var manager = new Manager();
            Console.WriteLine("Vacation days for manager = " + manager.GetVacationDays());

            Console.ReadLine();
        }
    }
}