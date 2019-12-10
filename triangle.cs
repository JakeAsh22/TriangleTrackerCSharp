using System;
using System.Collections.Generic;

public class Triangle
{
    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle(int side1,int side2, int side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }
    public string whichTri()
    {
        if (Side1 > (Side2 + Side3) || Side2 > (Side1 + Side3)|| Side3 > (Side1+Side2))
        {
            return "This is not a triangle";
        }
        else if (Side1 != Side2 && Side1 != Side3 && Side2 != Side3)
        {
            return "This is a Scalene Triangle";
        }
        else if (Side1==Side2 && Side2==Side3)
        {
            return "This is an Equilateral Triangle";
        }
        else 
        {
            return "This is an Isosceles Triangle";
        }
    }
}

public class Program 
{
    public static void Main()
    {
        Console.WriteLine("Please enter the length of the first side of the triangle: ");
        int side1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the length of the second side of the triangle: ");
        int side2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the length of the third side of the triangle: ");
        int side3 = int.Parse(Console.ReadLine());

        Triangle userTri = new Triangle(side1,side2,side3);
        Console.WriteLine(userTri.whichTri());
    }
}