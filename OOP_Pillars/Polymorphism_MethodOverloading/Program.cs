namespace Polymorphism_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading 

            var carGps = new CarGps();

            Console.WriteLine(carGps.SwitchRoute("Gouda"));
            Console.WriteLine(carGps.SwitchRoute("Gouda", "Iasi"));
            Console.WriteLine(carGps.SwitchRoute("Gouda", "Iasi", "Eindhoven"));

            Console.WriteLine("******");

            // constructor overloading

            var person1 = new Person("John Smith 1");
            var person2 = new Person("John Smith 2", "215414540");
            var person3 = new Person("John Smith 3", "215414542", 35);

            Console.WriteLine("Person 1: " + person1.DisplayInfo());
            Console.WriteLine("Person 2: " + person2.DisplayInfo());
            Console.WriteLine("Person 3: " + person3.DisplayInfo());

            Console.ReadLine();
        }
    }
}