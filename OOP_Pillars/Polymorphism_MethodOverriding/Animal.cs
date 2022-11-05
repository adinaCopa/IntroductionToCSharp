namespace Polymorphism_MethodOverriding
{
    internal class Animal
    {
        // use 'virtual' keyword when you want to override the method inside the child classes 

        public virtual string MakeNoise()
        {
            return "Roar";
        }
    }
}
