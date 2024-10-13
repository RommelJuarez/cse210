using System;

class Program
{
    static void Main(string[] args)
    {   
        
        Video video1=new Video("How to sleep","Rommel Juarez",10);
        video1.AddComment(new Comment(new string[]{"@user123","Very helpful thanks"}));
        video1.AddComment(new Comment(new string[]{"Juan","Thank you so much"}));

        Video video2=new Video("How to dance Salsa","Rommel Juarez",20);
        video2.AddComment(new Comment(new string[]{"Salsa Cali","muy chevere!!"}));
        video2.AddComment(new Comment(new string[]{"Juan Camilo","So cool Parcero!!"}));

        video1.ShowVideoInfo();
        Console.WriteLine();
        video2.ShowVideoInfo();
    }
}