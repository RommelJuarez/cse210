using System;

public class BreathingActivity:Activity{
    public BreathingActivity():base("Breathing","This activity will help you relax by guiding you through breathing exercises. Clear your mind and focus on your breath."){
        Run();
    }
    public void Run(){
        DisplayStartingMessage();
        int _totalTime=_duration;
        Console.WriteLine("Get ready...");
        ShowAnimation(6);
        while(_totalTime>0){
            Console.WriteLine();
            Console.Write("Breath in....");
            CountDown(4);
            Console.WriteLine();
            Console.Write("Breath out...");
            CountDown(6);
            Console.WriteLine();
            _totalTime-=10;
        }
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowAnimation(6);
        DisplayEndingMessage();
        ShowAnimation(6);
    }
}