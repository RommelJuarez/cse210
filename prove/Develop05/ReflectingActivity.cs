using System;
public class ReflectingActivity:Activity{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity():base("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience."){
        _prompts = new List<string> {
            "Think of a time when you overcame a tough challenge.",
            "Reflect on a moment when you helped someone in need.",
            "Remember a time when you achieved something you were proud of."
        };

        _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "How did this experience change your perspective?",
            "What did you learn from this experience that applies to your life now?"
        };

        
        Run();
    }
     public void Run()
    {
        DisplayStartingMessage();  
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(6);
        DisplayPrompt();           
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now, reflect on the following questions:"); 
        Console.Write("You may begin in:");
        CountDown(6);
        Console.Clear();

        DisplayQuestions();       
        
        Console.WriteLine("Well done!...");
        ShowAnimation(5);          
        
        DisplayEndingMessage();    
        ShowAnimation(6);
    }

    
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    
    public void DisplayPrompt()
    {
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
    }

    
    public void DisplayQuestions()
    {
        for (int i = 0; i < 2; i++)  
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"- {question}");
            ShowAnimation(6);  
        }
    }
}