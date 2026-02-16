using System;

class Pentagon
{
    private double side;

    public Pentagon()
    {
        side = 0;
    }

    public Pentagon(double sideLength)
    {
        side = sideLength;
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }

    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
    }

    public void Display()
    {
        Console.WriteLine("Side length: " + side);
        Console.WriteLine("Perimeter: " + GetPerimeter().ToString("F3"));
        Console.WriteLine("Area: " + GetArea().ToString("F3"));
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("-----------------------");
        Pentagon p1 = new Pentagon();
        p1.Display();

        Console.WriteLine();

        Console.WriteLine("Pentagon p2");
        Console.WriteLine("-----------------------");
        Pentagon p2 = new Pentagon(5);
        p2.Display();
    }
}
