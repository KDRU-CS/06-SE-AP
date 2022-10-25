using MyTestFramework.TestFramework;
using static MyTestFramework.src.MathLib;

namespace MyTestFramework.test;

[TestClass]
public class MathLibTest
{
    [TestMethod]
    public void TestAdd()
    {
        // Arrange

        // Act
        var result = Add(1, 2, 3, 4, 5, 6);

        // Assert
        Console.WriteLine(result == 21 ? "Add: true" : "Add: false");
    }

    [TestMethod]
    public void TestSubtract()
    {
        // Arrange

        // Act
        var result = Subtract(10, 4);

        // Assert
        Console.WriteLine(result == 6 ? "Subtract: true" : "Subtract: false");
    }
}