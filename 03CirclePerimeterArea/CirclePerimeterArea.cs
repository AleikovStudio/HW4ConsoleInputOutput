using System;

class CirclePerimeterArea
{
    static void Main()
    // Perimeter (Circumference) of a circle: C=2πr
    // Area of a circle: A=πr2
    // Program for calculating the Area and the Perimeter (Circumference) of a circle
    {
        Console.WriteLine("Please write the radius of your circle to find the circumference (C=2πr) of your circle: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double area = 2 * pi * radius;
        Console.WriteLine("The Perimeter or Circumference (C=2πr) of your circle is: {0:0.00}", area);

        Console.WriteLine("\n");

        Console.WriteLine("Please write the radius of your circle to find the area (A=πr2) of your circle: ");
        double radius2 = double.Parse(Console.ReadLine());
        double pi2 = Math.PI;
        double circumference = pi2 * (radius2 * radius2);
        Console.WriteLine("The Area (A=πr2) of your circle is: {0:0.00}", circumference);

    }
}