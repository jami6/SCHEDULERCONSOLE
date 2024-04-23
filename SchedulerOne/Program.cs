
using SchedulerOne;

var configData = new Config
{
    ConfDateTime = new DateTime(2024, 5, 4, 3, 40, 5),
    CurrentDate = DateTime.Now,
    OccurenceType = "recurring",
    OccursEvery = "monthly",
    Days = 0,
    StartDate = new DateOnly(2024, 3, 1)
};

var compute = new Computation();
var result = compute.ComputeNextDate(configData);
Console.WriteLine($"Output\nNext Execution Date -> {result}");

