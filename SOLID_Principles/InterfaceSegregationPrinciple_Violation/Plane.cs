namespace InterfaceSegregationPrinciple_Violation
{
    internal class Plane : IVehicle
    {
        public string Drive()
        {
            throw new NotImplementedException();
        }

        public string Fly()
        {
            return "Flying a plane";
        }
    }
}
