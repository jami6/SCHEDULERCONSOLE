namespace SchedulerClassLib;

public class Computation
{
    public static Tuple<DateOnly, string> ComputeNextDate(Config config)
    { 
        var occurenceType = config.OccurenceType;
        var currentDate = config.CurrentDate;
        DateOnly nextDate = default;
        var description = "";
        
        GuardHelper.ValidateInput(config);
        
        if (occurenceType == Occurence.Recurring)
        {
            nextDate = currentDate.AddDays(config.OccursEvery);
            description = $"Schedule will be used starting on {config.StartDate}";
        }
        
        else if (occurenceType == Occurence.Once)
        {
            DateOnly date = DateOnly.FromDateTime(config.ConfDateTime);
            TimeOnly time = TimeOnly.FromDateTime(config.ConfDateTime);
            nextDate = currentDate.AddDays(+1);
            description = $"Schedule will be used on {date} at {time} starting on {config.StartDate}";
        }
        return Tuple.Create(nextDate, description);
    }
}



