
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

var compute = new Computation();
compute.ComputeNextDate(configData);





