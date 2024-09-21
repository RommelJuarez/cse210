using System;

class Program
{
    static void Main(string[] args)
    {   
        
        
        string gradeLetter;
        string gradeSign;
        string message;

        Console.WriteLine("What is yout grade percentage?");
        double gradePercentage= double.Parse(Console.ReadLine());

        double remainder=Math.Round(gradePercentage%10,1);
        
        if(remainder>=0.7)
        {
            gradeSign="+";
        }
        else
        {
            gradeSign="-";
        };


        if(gradePercentage>=90)
        {
            gradeLetter="A";
            message="approved";
        }
        else if(gradePercentage>=80)
        {
            gradeLetter="B";
            message="approved"; 
        } 
        else if(gradePercentage>=70)
        {
            gradeLetter="C";
            message="approved";
        } 
        else if(gradePercentage>=60)
        {
            gradeLetter="D";
            message="not approved";
        } 
        else
        {
            gradeLetter="F";
            message="not approved";
        }    


        Console.WriteLine($"Your grade is: {gradeLetter+gradeSign}, {message}");

        
    }
}