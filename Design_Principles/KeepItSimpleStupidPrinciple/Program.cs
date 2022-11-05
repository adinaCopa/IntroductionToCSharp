namespace KeepItSimpleStupidPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var violation = new KISS_Violation();
            Console.WriteLine(violation.GetWeekDay(6));

            var fix = new KISS_fix();
            Console.WriteLine(fix.GetWeekDay(6));

            Console.ReadLine();
        }
    }
}