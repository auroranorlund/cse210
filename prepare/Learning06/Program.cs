using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 2);
        Rectangle rectangle = new Rectangle("black", 5, 2);
        Circle circle = new Circle("gold", 4);

        List<Shape> shapes = new List<Shape>{square, rectangle, circle};
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}