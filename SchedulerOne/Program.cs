
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

Func<Config, Tuple<DateTime, string>> calculateNextDate = (Config p) => Tuple.Create(DateTime.Now, "Hello");
// var compute = new Computation();
var result = calculateNextDate(configData);
Console.WriteLine($"Output\nNext Execution Date -> {result}");



