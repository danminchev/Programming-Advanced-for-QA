using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() {"d"};

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("d -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "didko" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("d -> 2");
        sb.AppendLine("i -> 1");
        sb.AppendLine("k -> 1");
        sb.AppendLine("o -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "di-dKooo!", "7" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("d -> 2");
        sb.AppendLine("i -> 1");
        sb.AppendLine("- -> 1");
        sb.AppendLine("K -> 1");
        sb.AppendLine("o -> 3");
        sb.AppendLine("! -> 1");
        sb.AppendLine("7 -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

