
using SchedulerOne;

var configData = new Config
{
    ConfDateTime = new DateTime(2024, 5, 4, 3, 40, 5),
    CurrentDate = new DateOnly(2020,1,4),
    OccurenceType = Occurence.Recurring,
    OccursEvery = "monthly",
    Days = 0,
    StartDate = new DateOnly(2020, 1, 1),
    EndDate = new DateOnly(2020, 1, 8),
};

Func<Config, Tuple<DateOnly, string>> calculateNextDate = (Config config) =>
{ 
    var occurenceType = config.OccurenceType;
    var currentDate = config.CurrentDate;
    DateOnly nextDate = default;
    var description = "";
    
   /* First Guard: StartDate is after current Date */
    if (configData.StartDate > configData.CurrentDate)
    {
        throw new Exception("StartDate is After current Date");
    }
    
    /* Second Guard: End date check */
    if (configData.EndDate != null && configData.CurrentDate > config.EndDate)
    {
        throw new Exception("Current Date is After End Date");
    }
  
        
    if (occurenceType == Occurence.Recurring)
    {
        nextDate = currentDate.AddDays(1);
        description = $"Schedule will be used starting on {config.StartDate}";
    }
        
    else if (occurenceType == Occurence.Once)
    {
        DateOnly date = DateOnly.FromDateTime(config.ConfDateTime);
        TimeOnly time = TimeOnly.FromDateTime(config.ConfDateTime);
        nextDate = currentDate.AddDays(+1);
        description = $"Schedule will be used on {date} at {time} starting on {config.StartDate}";
    }
    return Tuple.Create(nextDate, description)!;
};

var result = calculateNextDate(configData);
Console.WriteLine($"Output\nNext Execution Date -> {result}");




