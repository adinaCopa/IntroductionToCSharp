namespace Polymorphism_MethodOverriding
{
    internal class Cat : Animal
    {
        // use 'override' keyword when you want to override the method from the parent class

        public override string MakeNoise()
        {
            return "Meeeooow";
        }
    }
}
