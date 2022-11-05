namespace KeepItSimpleStupidPrinciple
{
    internal class KISS_Violation
    {
        public string GetWeekDay(int day)
        {
            switch (day)
            {
                case 1:
                    return DayOfWeek.Monday.ToString();
                case 2:
                    return DayOfWeek.Tuesday.ToString();
                case 3:
                    return DayOfWeek.Wednesday.ToString();
                case 4:
                    return DayOfWeek.Thursday.ToString();
                case 5:
                    return DayOfWeek.Friday.ToString();
                case 6:
                    return DayOfWeek.Saturday.ToString();
                case 7:
                    return DayOfWeek.Sunday.ToString();
                default:
                    return "Day must be in range 1 to 7.";
            }
        }
    }
}
