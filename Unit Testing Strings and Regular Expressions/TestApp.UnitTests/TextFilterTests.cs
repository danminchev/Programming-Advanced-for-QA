using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Hi Dikdo";
        string[] bannedWord = new string[] { "089" };
      
        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "0899145677";
        string[] bannedWord = new string[] { "9145677" };
        string expected = "089*******";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Hi Dikdo";
        string[] bannedWord = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string text = "089 9 145 677";
        string[] bannedWord = new string[] { " 9 145 677" };
        string expected = "089**********";

        // Act
        string result = TextFilter.Filter(bannedWord, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
