using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = new int[0];

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 2, 100, 1, 1000000000, 1 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 2");
        sb.AppendLine("100 -> 1");
        sb.AppendLine("1000000000 -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1000000000, -100, -2, -1, -1, -2, -1 };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("-1000000000 -> 1");
        sb.AppendLine("-100 -> 1");
        sb.AppendLine("-2 -> 2");
        sb.AppendLine("-1 -> 3");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0, 0, 0, 0, 0 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("0 -> 5");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
