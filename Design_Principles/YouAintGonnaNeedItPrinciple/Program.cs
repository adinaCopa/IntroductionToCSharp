namespace YouAintGonnaNeedItPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;

            var violation = new YAGNI_violation();
            var sum = violation.CalculateSum(a, b);

            // you don't need a special method to calculate a sum

            var simpleSum = a + b;

            Console.ReadLine();
        }
    }
}