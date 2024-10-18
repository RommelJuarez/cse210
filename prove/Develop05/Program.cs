using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;  
        
        while (running)
        {
            
            Console.Clear();
            Console.WriteLine("=== Activity Menu ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");
            
            
            string option = Console.ReadLine();
            
            switch (option)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();  
                    break;

                case "2":
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity();  
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();  

                case "4":
                    Console.Clear();
                    Console.WriteLine("Exiting program. Goodbye!");
                    running = false;  
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option. Please select a number between 1 and 4.");
                    break;
            }
            
            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();  
            }
        }
    }
}
