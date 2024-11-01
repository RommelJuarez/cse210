using System;
public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }
    public override double GetDistance() => (GetSpeed() / 60) * GetLengthInMinutes();
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / GetSpeed();
}
