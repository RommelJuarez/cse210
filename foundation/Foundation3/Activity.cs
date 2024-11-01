using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public DateTime GetDate() => _date;
    public int GetLengthInMinutes() => _lengthInMinutes;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {GetType().Name} ({GetLengthInMinutes()} min) - " +
               $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}