﻿using System;

// Abstract base class
public abstract class Shape
{
    public abstract double GetArea();
}

// Derived class
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class
public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine("Area of circle: " + circle.GetArea());
        Console.WriteLine("Area of rectangle: " + rectangle.GetArea());
    }
}
