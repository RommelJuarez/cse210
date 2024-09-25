using System;


class Program
{
    static void Main(string[] args)
    {
        

        Job job1=new Job();

        job1._jobTitle="Software Engineer";
        job1._company="Apple";
        job1._startYear="2022";
        job1._endYear="2024";

        Job job2=new Job();

        job2._jobTitle="Astronaut";
        job2._company="NASA";
        job2._startYear="2019";
        job2._endYear="2021";

        
        
        Resume resume1=new Resume();

        resume1._name="Rommel Juarez";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

        

        
    }
}