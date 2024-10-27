using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true; 

        while (running)
        {
            
            Console.WriteLine("===================================");
            Console.WriteLine("         Eternal Quest");
            Console.WriteLine("===================================");

            
            Console.WriteLine("\nGoals:");
            if (_goals.Count > 0)
            {
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                }
            }
            else
            {
                Console.WriteLine("No Goals yet");
            }

            Console.WriteLine($"\nPoints: {_score}");
            Console.WriteLine("\n===================================");

            
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option(1-6): ");

            
            string choice = Console.ReadLine();

            
            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case "3":
                    SaveGoalsMenu();
                    break;

                case "4":
                    LoadGoalsMenu();
                    break;

                case "5":
                    RecordEventMenu();
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("See you later!!");
                    break;

                default:
                    Console.WriteLine("not valid option");
                    break;
            }
        }
    }

    
    private void CreateNewGoal()
    {
        Console.WriteLine("Choose the type of your goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalType = Console.ReadLine();

        Console.Write("Name for the Goal: ");
        string name = Console.ReadLine();
        Console.Write("Description for the Goal: ");
        string description = Console.ReadLine();
        Console.Write("Points for complete the Goal: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == "2")
        {
            EternalGoal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times it will require to complete: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Goal Type not valid");
        }
    }

    
    private void SaveGoalsMenu()
    {
        Console.Write("File name: ");
        string filename = Console.ReadLine();
        SaveGoals(filename);
        Console.WriteLine("Saved");
    }

        private void LoadGoalsMenu()
    {
        Console.Write("File name: ");
        string filename = Console.ReadLine();
        LoadGoals(filename);
        Console.WriteLine("Loaded");
    }

    
    private void RecordEventMenu()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.Write("Choose the number of the goal to complete: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            RecordEvent(goalIndex);
            Console.WriteLine("Completed!!");
        }
        else
        {
            Console.WriteLine("Number of goal not valid");
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score:{_score}");
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            _goals.Clear(); 
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                if (line.StartsWith("Score:"))
                {
                    
                    _score = int.Parse(line.Split(":")[1]);
                }
                else
                {
                    string[] parts = line.Split(":"); 
                    string goalType = parts[0]; 
                    string details = parts[1];  
                    string[] properties = details.Split(",");

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal goal = new SimpleGoal(properties[0], properties[1], int.Parse(properties[2]));
                        if (bool.Parse(properties[3])) goal.RecordEvent();
                        _goals.Add(goal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal goal = new EternalGoal(properties[0], properties[1], int.Parse(properties[2]));
                        _goals.Add(goal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        ChecklistGoal goal = new ChecklistGoal(properties[0], properties[1], int.Parse(properties[2]), int.Parse(properties[3]), int.Parse(properties[4]));
                        for (int i = 0; i < int.Parse(properties[5]); i++) goal.RecordEvent();
                        _goals.Add(goal);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"The file {filename} does not exist");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        Goal goal = _goals[goalIndex];
        goal.RecordEvent();

        if (goal.IsComplete())
        {
            _score += goal._points;
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal._points; 
            }
        }
    }
}
