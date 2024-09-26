using System;

class Program

{

    static void Main(string[] args)
{
    // DisplayWelcome - Displays the message, "Welcome to the Program!" **
    // PromptUserName - Asks for and returns the user's name (as a string) **
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)**
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)**
    // DisplayResult - Accepts the user's name and the squared number and displays them. 



    DisplayWelcome();
    string userName = PromptUserName();
    int favNumber = PromptUserNumber();
    int squaredNumber = SquareNumber(favNumber);
    DisplayResult(userName, squaredNumber);


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string usersName = Console.ReadLine();
        return usersName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int numberToSquare)
    {
        int squaredNumber = numberToSquare * numberToSquare;
        return squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is: {squaredNumber}");
    }
}

}