namespace InterfaceSegregationPrinciple
{
    internal class MultifunctionalVehicle : ICar, IPlane
    {
        public string Drive()
        {
            return "Driving a multifunctional vehicle";
        }

        public string Fly()
        {
            return "Flying a multifunctional vehicle";
        }
    }
}
