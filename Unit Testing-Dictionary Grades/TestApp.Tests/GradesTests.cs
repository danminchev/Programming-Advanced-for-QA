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
        Dictionary<string, int> grades = new Dictionary<string, int>
    {
        {"Alice", 90},
        {"Bob", 85},
        {"Charlie", 95},
        {"David", 80},
        {"Eve", 92}
    };

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        string[] expectedLines =
        {
        "Alice with average grade 90.00",
        "Charlie with average grade 95.00",
        "Eve with average grade 92.00"
    };
        string[] actualLines = result.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(expectedLines);
        Array.Sort(actualLines);

        CollectionAssert.AreEqual(expectedLines, actualLines);
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>();

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>
            {
                {"Alice", 90},
                {"Bob", 85}
            };

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        string[] expectedLines =
        {
                "Alice with average grade 90.00",
                "Bob with average grade 85.00"
            };
        string[] actualLines = result.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        Assert.AreEqual(expectedLines, actualLines);
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>
            {
                {"Alice", 90},
                {"Bob", 90},
                {"Charlie", 90}
            };

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        string[] expectedLines =
        {
                "Alice with average grade 90.00",
                "Bob with average grade 90.00",
                "Charlie with average grade 90.00"
            };
        string[] actualLines = result.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        Assert.AreEqual(expectedLines, actualLines);
    }  
}
