namespace InterfaceSegregationPrinciple_Violation
{
    internal class Car : IVehicle
    {
        public string Drive()
        {
            return "Driving a car";
        }

        public string Fly()
        {
            throw new NotImplementedException();
        }
    }
}
