using System;
public class Running : Activity
{
    private double _distance; 
    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }
    public override double GetDistance() => _distance;
    public override double GetSpeed() => (GetDistance() / GetLengthInMinutes()) * 60;
    public override double GetPace() => GetLengthInMinutes() / GetDistance();
}