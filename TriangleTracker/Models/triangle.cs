using System;
using MainProgram;

namespace Formula
{
 public class Triangle
{
     int Side1;
    int Side2;
     int Side3;

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
}