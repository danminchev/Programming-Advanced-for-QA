using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            ["Gosho"] = 5,
            ["Ivan"] = 3,
            ["Petkan"] = 4,
            ["Stoian"] = 6,
            ["Pesho"] = 2,
        };
        // Act
        string result = Grades.GetBestStudents(gradesDict);
        string expected = $"Stoian with average grade 6.00" +
            $"{Environment.NewLine}Gosho with average grade 5.00" +
            $"{Environment.NewLine}Petkan with average grade 4.00";


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
        };
        // Act
        string result = Grades.GetBestStudents(gradesDict);
        string expected = "";


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            ["Gosho"] = 5,
            ["Ivan"] = 3,
        };
        // Act
        string result = Grades.GetBestStudents(gradesDict);
        string expected = $"Gosho with average grade 5.00" +
            $"{Environment.NewLine}Ivan with average grade 3.00";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            ["Gosho"] = 5,
            ["Ivan"] = 5,
            ["Petkan"] = 5,
            ["Stoian"] = 5,
            ["Pesho"] = 5,
        };
        // Act
        string result = Grades.GetBestStudents(gradesDict);
        string expected = $"Gosho with average grade 5.00" +
            $"{Environment.NewLine}Ivan with average grade 5.00" +
            $"{Environment.NewLine}Pesho with average grade 5.00";


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
