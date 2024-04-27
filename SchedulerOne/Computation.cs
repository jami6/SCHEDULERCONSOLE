// using SchedulerOne;
//
// public class Computation
// {
//     private DateTime _nextDate;
//     private string _description;
//     
//     public (DateTime, string) ComputeNextDate(Config config)
//     {
//         var occurenceType = config.OccurenceType;
//         var currentDate = config.CurrentDate;
//         
//         if (occurenceType == "recurring")
//         {
//             int interval = 1;
//             _nextDate = currentDate.AddDays(1);
//             _description = $"Schedule will be used starting on {config.StartDate}";
//         }
//         
//         else if (occurenceType == "once")
//         {
//             DateOnly date = DateOnly.FromDateTime(config.ConfDateTime);
//             TimeOnly time = TimeOnly.FromDateTime(config.ConfDateTime);
//             _nextDate = currentDate.AddDays(+1);
//             
//             _description = $"Schedule will be used on {date} at {time} starting on {config.StartDate}";
//         }
//
//         return (_nextDate, _description);
//     }
// }