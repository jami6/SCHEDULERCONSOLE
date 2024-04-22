namespace SchedulerOne.SchedulerClasses;

public class OnceOccurence:ITimeScheduler
{
    private DateTime CurrentDate { get; set; }

    public OnceOccurence(DateTime currentDate)
    {
        CurrentDate = currentDate;
    }
    public void CalculateTime()
    {
        Console.WriteLine("Once Set");
        
        Console.WriteLine("Enter Date(DD/MM/YY):");
        var confDateOnly = Console.ReadLine();
        
        Console.WriteLine("Enter Time (H:M)");
        var confTime = Console.ReadLine();
        var (hours, minutes) = DateHelpers.ReturnFormatedTime(confTime);
        
        Console.WriteLine("Enter Start Date(DD/MM/YY):");
        var confStartDate = Console.ReadLine();
        
        Console.WriteLine($"Output\nNext Execution Date -> {DateOnly.FromDateTime(CurrentDate.AddDays(+1))}");
        Console.WriteLine($"Description: Schedule will be used on {confDateOnly} at {confTime} starting on {confStartDate}");
    }
}