using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, 3);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "abc";

        // Act
        string result = StringRotator.RotateRight(input, 0);

        // Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        int positions = 2;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual("efabcd", result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "xyz";
        int positions = -1;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual("zxy", result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "12345";
        int positions = 8;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual("34512", result);
    }
}
