namespace OpenClosedPrinciple_Violation
{
    internal class Job
    {
        private const int DefaultVacationDays = 25;

        public JobType Type { get; private set; }

        public Job(JobType type)
        {
            this.Type = type;
        }

        public int GetVacationDays()
        {
            if (this.Type == JobType.SoftwareDeveloper)
            {
                return DefaultVacationDays + 3;
            }

            if (this.Type == JobType.SoftwareTester)
            {
                return DefaultVacationDays + 5;
            }

            return DefaultVacationDays;
        }
    }
}
