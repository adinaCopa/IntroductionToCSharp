namespace DontRepeatYourselfPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DRY_violation.DisplayPeter();
            DRY_violation.DisplayIris();
            DRY_violation.DisplayMartin();

            Console.WriteLine("*** DRY fix ***");

            DRY_fix.DisplayPeter();
            DRY_fix.DisplayIris();
            DRY_fix.DisplayMartin();

            Console.ReadLine();
        }
    }
}