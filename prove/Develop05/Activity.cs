using System;
public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(){
        _name="unknown";
        _description="unknown";
        _duration=0;

    }
    public Activity(string name,string description){
        _name=name;
        _description=description;
        

    }
    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session:");
        _duration=int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"You have been completed another {_duration} seconds of the {_name} Activity");

    }
    public void ShowAnimation(int seconds)
    {
        int totalDuration = seconds * 1000; 
        int elapsedTime = 0;

        while (elapsedTime < totalDuration)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");   
                Thread.Sleep(1000);    
                elapsedTime += 1000;   

                if (elapsedTime >= totalDuration)
                {
                    break; 
                }
            }
            Console.Write("\b\b\b\b    \b\b\b\b");
        }
        Console.WriteLine();
    }
    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);   
            Thread.Sleep(1000);
            Console.Write("\b \b");     
        }
        Console.Write(" ");
    }

}