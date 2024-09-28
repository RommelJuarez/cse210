using System;

class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal journal=new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int option = 0;

        while (option != 5)
        {
            Console.Clear(); 
            Console.WriteLine("===== JOURNAL =====");
            Console.WriteLine("Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do (1-5): ");

            
            
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("");
                        string randomPrompt = promptGenerator.RandomPrompt();
                        Console.WriteLine(randomPrompt);
                        string entry2=Console.ReadLine();
                        Entry entry = new Entry(randomPrompt,entry2);
                        journal.AddEntry(entry);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        journal.DisplayAll(); 
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.Write("File name to Load: ");
                        string loadPath = Console.ReadLine();
                        journal.LoadFromFile(loadPath);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.Write("File name to Save: ");
                        string savePath = Console.ReadLine();
                        journal.SaveToFile(savePath);
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("See you later...");
                        break;
                    default:
                        Console.WriteLine("Option incorrect try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            if (option != 5)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }





}

