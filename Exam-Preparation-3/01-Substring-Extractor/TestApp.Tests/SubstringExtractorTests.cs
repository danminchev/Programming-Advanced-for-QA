using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "aaa bbb ccc";
        string startMarcer = "aaa";
        string endMarcer = "ccc";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarcer, endMarcer);

        // Assert
        Assert.That(result, Is.EqualTo(" bbb "));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaa bbb ccc";
        string startMarcer = "dd";
        string endMarcer = "ccc";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarcer, endMarcer);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaa bbb ccc";
        string startMarcer = " bbb ";
        string endMarcer = "dd";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarcer, endMarcer);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "dd bbb ccc";
        string startMarcer = "ee";
        string endMarcer = "dd";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarcer, endMarcer);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string startMarcer = "ee";
        string endMarcer = "dd";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarcer, endMarcer);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "eedd";
        string startMarcer = "ee";
        string endMarcer = "ed";
    }
}
