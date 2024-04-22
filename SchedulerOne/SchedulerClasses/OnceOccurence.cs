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
        
        Console.WriteLine("Enter Start Date(DD/MM/YY):");
        var confDateTime = Console.ReadLine();
        
        Console.WriteLine("Enter Time (H:M)");
        var confTime = Console.ReadLine();
        var (hours, minutes) = DateHelpers.ReturnFormatedTime(confTime);
      
        Console.WriteLine("Enter Description");
        var description = Console.ReadLine();
      
    }
}