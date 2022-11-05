namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            var dogEat = dog.Eat();
            var dogBark = dog.Bark();

            Console.WriteLine(dogEat);
            Console.WriteLine(dogBark);

            Console.WriteLine("******");

            var cat = new Cat();
            var catEat = cat.Eat();
            var catMeow = cat.Meow();

            Console.WriteLine(catEat);
            Console.WriteLine(catMeow);

            Console.ReadLine();
        }
    }
}