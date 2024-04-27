namespace SchedulerOne;

public class Config
{
    public DateTime ConfDateTime { get; set; }
    public DateTime CurrentDate { get; set; }
    public string? OccurenceType { get; set; }
    public string? OccursEvery { get; set; }
    public int Days { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}