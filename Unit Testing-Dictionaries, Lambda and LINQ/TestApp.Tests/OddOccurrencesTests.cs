using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[0];

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "Didko", "Didko" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "didko" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("didko"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "didko",  "in", "the", "on", "the", "on", "a", "in", "the" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("didko the a"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "DiDko", "in", "tHe", "on", "thE", "on", "A", "in", "The" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("didko the a"));
    }
}
