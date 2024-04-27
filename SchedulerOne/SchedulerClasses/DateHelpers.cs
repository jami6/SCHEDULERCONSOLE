namespace SchedulerOne;

public class DateHelpers
{
    public static DateOnly ReturnFormatedDateFromString(string myDate)
    {
        var startDate = myDate.Split("/");
        int year = Convert.ToInt32(startDate[2]);
        int month = Convert.ToInt32(startDate[1]);
        int day = Convert.ToInt32(startDate[0]);
        //var formatedStartDate = DateOnly.FromDateTime(new DateTime(year,month,day));
        var formatedStartDate = new DateOnly(year,month,day);
        return formatedStartDate;
    }

    public static Tuple<int, int> ReturnFormatedTime(string myTime)
    {
        var startTime = myTime.Split(":");
        int hours = Convert.ToInt32(startTime[0]);
        int minutes = Convert.ToInt32(startTime[1]);
        return Tuple.Create(hours, minutes);
    }
}
