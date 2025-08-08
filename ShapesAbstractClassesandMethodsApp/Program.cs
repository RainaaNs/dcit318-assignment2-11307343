using System;

public abstract class Shape
{
    public abstract double GetArea();
}


public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle (double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class Rectangle : Shape
{
    public double Length { get; set; }
    
    public double Width { get; set; }

    public Rectangle(double Length, double Width) {
        this.Length = Length;
        this.Width = Width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }   
}


public class Program
{
    public static void Main(string[] args)
    {
        // Circle circle = new Circle(5);
        // Rectangle rectangle = new Rectangle(4, 6);

        // Console.WriteLine("Circle Area: " + circle.GetArea());
        // Console.WriteLine("Rectangle Area: " + rectangle.GetArea());    

        Console.Write("Enter radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(radius);

        Console.WriteLine($"Area of Circle: {circle.GetArea():F2}");


        Console.Write("Enter width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of the rectangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);
        
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea():F2}");
    }
}
