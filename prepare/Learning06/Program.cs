using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        List<Shape> shapes=new List<Shape>();

        Square s1=new Square("blue",5);
        shapes.Add(s1);

        Rectangle s2=new Rectangle("red",5,6);
        shapes.Add(s2);

        Circle s3=new Circle("yellow",10);
        shapes.Add(s3);

        foreach (Shape shp in shapes)
        {
            string color=shp.GetColor();

            double area=shp.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}