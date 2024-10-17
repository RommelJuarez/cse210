using System;

class Program
{
    static void Main(string[] args)
    {
       

        Assignment assignment1= new Assignment("Rommel","Math");
        Console.WriteLine(assignment1.GetSummary());
        
        Console.WriteLine();
        MathAssignment mathA= new MathAssignment("5.5","1-10","Ariel","Divisions");
        Console.WriteLine(mathA.GetSummary());
        Console.WriteLine(mathA.GetHomeworkList());

        Console.WriteLine();
        WritingAssignment wA=new WritingAssignment("Auto-Biography","Keiri","Essay");
        Console.WriteLine(wA.GetSummary());
        Console.WriteLine(wA.GetWritingInformation());
    }   
}