using System;
class Program
{
    static void Main(string[] args)
    {
        //For the creativity feature: 
        //I added the functionality to hide words using the right arrow key 
        //and to go back and reveal the most recently hidden word using the left arrow key
        //for quit the program press the the key "q"

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

                if (!historyManager.RestorePreviousState(_scripture.GetWords()))
                {
                    Console.WriteLine("\nHide first");
                }
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {

                historyManager.SaveState(_scripture.GetWords());


                _scripture.HideWords(2);
            }
        }

        _scripture.Display();
        Console.WriteLine("\n\nAll words are hidden!");
    }
}
