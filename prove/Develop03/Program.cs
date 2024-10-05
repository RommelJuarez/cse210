using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference _reference = new Reference("Proverbs", 3, 5, 6);
        string _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture _scripture = new Scripture(_reference, _scriptureText);

        HistoryManager historyManager = new HistoryManager(); 

        while (!_scripture.AllWordsHidden())
        {
            _scripture.Display();

            Console.WriteLine("\n\nUse Right arrow to HIDE and Left arrow to SHOW \nPress the key 'q' to quit.");

            var keyInfo = Console.ReadKey(true); 

            if (keyInfo.Key == ConsoleKey.Q)
                break;

            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                
                if (!historyManager.RestorePreviousState(_scripture._words))
                {
                    Console.WriteLine("\nHide first");
                }
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                
                historyManager.SaveState(_scripture._words);

                
                _scripture.HideWords(2);
            }
        }

        _scripture.Display();
        Console.WriteLine("\n\nAll words are hidden!");
    }
}
