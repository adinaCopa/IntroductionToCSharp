namespace Polymorphism_OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box(5, 7);
            var box2 = new Box(9, 2);

            Console.WriteLine("Box 1: " + box1.DisplayInfo());
            Console.WriteLine("Box 2: " + box2.DisplayInfo());

            var box3 = box1 + box2;
            Console.WriteLine("Box 3: " + box3.DisplayInfo());

            Console.ReadLine();
        }
    }
}