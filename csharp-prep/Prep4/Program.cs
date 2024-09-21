using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers=new List<int>();
        int numberAdd;
        Console.WriteLine("Enter a list of numbers, type 0 when finished."); 
        do{
        Console.WriteLine("Enter a number:");    
        
        numberAdd=int.Parse(Console.ReadLine());
        numbers.Add(numberAdd);
        
        }while(numberAdd!=0);

        int sum=0;
        double avg=0;
        int maxNumber=numbers[0];

        foreach(int number in numbers)
        {
            sum=sum+number;
            
            if(number>maxNumber)
            {
                maxNumber=number;
            }

        }
        avg=sum/((numbers.Count)-1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The max number is : {maxNumber}");
        
    }
}