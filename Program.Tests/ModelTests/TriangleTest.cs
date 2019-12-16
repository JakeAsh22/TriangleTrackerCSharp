using Microsoft.VisualStudio.TestTools.UnitTesting;
using Formula;

namespace Program.Tests
{
  [TestClass]
  public class TriangleTest
  {
    [TestMethod]
    public void whichTri_NotATriangle_ThisIsNotATriangle()
    {
      Triangle testNot = new Triangle(3,5,20);
      Assert.AreEqual("This is not a triangle", testNot.whichTri());
    }
  [TestMethod]
    public void whichTri_IsScalene_ThisIsAScaleneTriangle()
    {
      Triangle testScal = new Triangle(2,3,4);
      Assert.AreEqual("This is a Scalene Triangle", testScal.whichTri());
    }
    [TestMethod]
    public void whichTri_IsEqualateral_ThisIsAnEquilateralTriangle()
    {
      Triangle testEqual = new Triangle(3,3,3);
      Assert.AreEqual("This is an Equilateral Triangle", testEqual.whichTri());
    }
    [TestMethod]
    public void whichTri_IsIsosceles_ThisIsAnIsoscelesTriangle()
    {
      Triangle testIso = new Triangle(3,3,2);
      Assert.AreEqual("This is an Isosceles Triangle", testIso.whichTri());
    }
  }
}