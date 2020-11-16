using System;
using static System.Console;

namespace Exercise02
{
    abstract class Shape
    {
        public abstract double Height { get; set; }
        public abstract double Width { get; set; }
        public abstract double Area();
        
    }

    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double Height { get; set; }
        public override double Width { get; set; }
        public override double Area() => Height * Width; 
    }

    class Square : Shape
    {
        public Square(double side)
        {
            Height = side;
            Width = side;
        }
        public override double Height { get; set; }
        public override double Width { get; set; }

        public override double Area() => Height * Width;
    }

    class Circle : Shape
    {
        public double Radius; 
        public Circle(double radius)
        {
            Height = radius * 2;
            Width = radius * 2;
            Radius = radius;
        }
        public override double Height { get; set; }
        public override double Width { get; set; }

        public override double Area() => Math.PI * Radius * Radius;
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Generating shapes...");
            var r = new Rectangle(3, 4.5);
            WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area()}");

            var s = new Square(5);
            WriteLine($"Rectangle H: {s.Height}, W: {s.Width}, Area: {s.Area()}");

            var c = new Circle(2.5);
            WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area:{ c.Area()}");
        }
    }
}
