namespace OpenClosedPrinciple_Violation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dev = new Job(JobType.SoftwareDeveloper);
            Console.WriteLine("Vacation days for developer = " + dev.GetVacationDays());

            var manager = new Job(JobType.Manager);
            Console.WriteLine("Vacation days for manager = " + manager.GetVacationDays());

            Console.ReadLine();
        }
    }
}