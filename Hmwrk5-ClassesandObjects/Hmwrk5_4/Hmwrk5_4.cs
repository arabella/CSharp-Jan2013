using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them.

class Hmwrk5_4
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the second side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the third side c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the altitude to side a:");
        double ha = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle between a and b:");
        int angle = int.Parse(Console.ReadLine());

        Console.WriteLine("The surface of the triangle calculated by given three sides is {0}", CalculateSurfaceabc(a, b, c));
        Console.WriteLine("The surface of the triangle calculated by given a side and an altitude to it is {0}", CalculateSurfaceaha(a, ha));
        Console.WriteLine("The surface of the triangle calculated by given two side and an ngle between them is {0}", CalculateSurfaceabangle(a, b, angle));
    }
    static double CalculateSurfaceabc(double a, double b, double c)
    {
        double perimeter = a + b + c;
        double surface = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        return surface;
    }

    static double CalculateSurfaceaha(double a, double ha)
    {
        double surface = (a * ha) / 2;
        return surface;
    }

    static double CalculateSurfaceabangle(double a, double b, int angle)
    {
        double angleInRadians = (Math.PI * angle) / 180.0;
        double surface = (a * b * Math.Sin(angleInRadians)) / 2;
        return surface;
    }
}