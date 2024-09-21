using System;

class Program
{
    static void Main(string[] args)
    {
        Random rd=new Random();
        int magicNumber=rd.Next(1,100);

        int response;
        int flag=0;
        do{
           Console.WriteLine("What is your guess?: ");
           response=int.Parse(Console.ReadLine());
           flag=flag+1;
           if(response>magicNumber)
           {
            Console.WriteLine("Lower");
           }
           else if(response<magicNumber)
           {
            Console.WriteLine("Higher");
           }
           else if(response==magicNumber)
           {
            Console.WriteLine($"You win!!, attempts: {flag}");
           }   
        }while(response!=magicNumber);


    }
}