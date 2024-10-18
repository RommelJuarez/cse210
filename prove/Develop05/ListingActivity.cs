using System;
public class ListingActivity:Activity{
    private int _count;  
    private List<string> _prompts;  

    public ListingActivity() : base("Listing", "This activity will help you reflect by listing as many things as you can based on a given prompt.")
    {
        
        _prompts = new List<string> {
            "List all the things you are grateful for.",
            "List all the places you would like to visit.",
            "List all the people who have influenced you positively."
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

        Console.WriteLine("Now, list as many things as you can based on the prompt.");
        Console.Write("You may begin in: ");
        CountDown(6);  
        

        
        List<string> userItems = GetListFromUser(_duration);
        
        
        _count = userItems.Count;
        Console.WriteLine($"Well done! You listed {_count} items.");
        
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

    
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    
   public List<string> GetListFromUser(int durationInSeconds)
{
    List<string> items = new List<string>();
    DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);  
    
    Console.WriteLine($"You have {durationInSeconds} seconds to list as many items as you can. Press Enter after each item:");
    
    
    while (DateTime.Now < endTime)
    {
        if (Console.KeyAvailable)  
        {
            string input = Console.ReadLine();
            items.Add(input);  
        }
    }

    return items;
}


}   