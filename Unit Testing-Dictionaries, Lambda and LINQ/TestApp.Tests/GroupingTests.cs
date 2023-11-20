using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new() { 1, 3, 7, 2, 4, 6 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Odd numbers: 1, 3, 7");
        sb.AppendLine("Even numbers: 2, 4, 6");
        
        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new() { 8, 2, 4, 6 };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Even numbers: 8, 2, 4, 6");

        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new() { 1, 5, 3, 7 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Odd numbers: 1, 5, 3, 7");

        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new() { -1, -3, -7, -2, -4, -6 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Odd numbers: -1, -3, -7");
        sb.AppendLine("Even numbers: -2, -4, -6");

        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
