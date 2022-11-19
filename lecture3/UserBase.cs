namespace lecture1;

public class UserBase
{
    public DateTime DateOfBirth { get; set; }
    public string CalculateAgeInDays()
    {
        var diff = DateTime.UtcNow.Subtract(DateOfBirth);
        return diff.TotalDays.ToString();
    }
}