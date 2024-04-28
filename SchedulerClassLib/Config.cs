namespace SchedulerClassLib;
public class Config
{
    public DateTime ConfDateTime { get; set; } //only happens in once scenario
    public DateOnly CurrentDate { get; set; } //input in all scenarios
    public Occurence OccurenceType { get; set; } //input in all scenarios
    public string? OccursEvery { get; set; } // input needed only in recurring
    public int Days { get; set; } // input needed in only recuring
    public DateOnly StartDate { get; set; } //input required for both

    public DateOnly? EndDate { get; set; } = null; //input required for both
}