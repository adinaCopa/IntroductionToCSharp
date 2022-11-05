namespace Polymorphism_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            Console.WriteLine("Cat noise: " + cat.MakeNoise());

            var lion = new Lion();
            Console.WriteLine("Lion noise: " + lion.MakeNoise());

            Console.ReadLine();
        }
    }
}