namespace InterfaceSegregationPrinciple
{
    internal class Car : ICar
    {
        public string Drive()
        {
            return "Driving a car";
        }
    }
}
