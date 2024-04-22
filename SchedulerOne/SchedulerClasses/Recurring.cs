namespace SchedulerOne.SchedulerClasses;

public class Recurring:ITimeScheduler
{ 
        private DateTime CurrentDate { get; set; }

        public Recurring(DateTime currentDate)
        {
                CurrentDate = currentDate;
        }
        public void CalculateTime()
        {
                Console.WriteLine("Recurring Set");
                Console.WriteLine("Enter Start Date(DD/MM/YY):");
                var confDateTime = Console.ReadLine();
    
                Console.WriteLine("Enter Description");
                var description = Console.ReadLine();
    
                Console.WriteLine("Enter Day Occurence");
                Console.WriteLine("1.Daily\n2.Weekly\n3.Monthly");
                int occurenceFrequency = Convert.ToInt32(Console.ReadLine());
                int interval = 1;
                switch (occurenceFrequency)
                {
                        case 1:
                                break;
                        case 2:
                                interval = 7;
                                break;
                        case 3:
                                interval = 30;
                                break;
                        default:
                                Console.WriteLine("Wrong Occurence Choice. Using Default, Daily");
                                break;
                }
                
                var formatedDate = DateHelpers.ReturnFormatedDateFromString(confDateTime);
                Console.WriteLine($"Output\nNext Execution Date -> {DateOnly.FromDateTime(CurrentDate.AddDays(interval))}");
                Console.WriteLine($"Description: {description}");
        }

}