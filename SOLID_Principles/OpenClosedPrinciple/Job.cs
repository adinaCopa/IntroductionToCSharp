namespace OpenClosedPrinciple
{
    internal class Job
    {
        private const int DefaultVacationDays = 25;

        public Job()
        {
        }

        public virtual int GetVacationDays()
        {
            return DefaultVacationDays;
        }
    }
}
