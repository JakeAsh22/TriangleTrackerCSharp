using System;
using System.Collections.Generic;
using Formula;

namespace MainProgram
{


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
}