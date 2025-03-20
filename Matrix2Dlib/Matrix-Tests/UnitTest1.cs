using Matrix2dLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public class Matrix2dTests
{
    [TestMethod]
    public void TestIdentityMatrix()
    {
        var id = Matrix2d.Id;
        Assert.Equals(new Matrix2d(1, 0, 0, 1), id);
    }

    [TestMethod]
    public void TestAddition()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(4, 3, 2, 1);
        Assert.Equals(new Matrix2d(5, 5, 5, 5), m1 + m2);
    }

    [TestMethod]
    public void TestDeterminant()
    {
        var m = new Matrix2d(1, 2, 3, 4);
        Assert.Equals(-2, m.Det());
    }

    [TestMethod]
    public void TestTranspose()
    {
        var m = new Matrix2d(1, 2, 3, 4);
        Assert.Equals(new Matrix2d(1, 3, 2, 4), Matrix2d.Transpose(m));
    }
}