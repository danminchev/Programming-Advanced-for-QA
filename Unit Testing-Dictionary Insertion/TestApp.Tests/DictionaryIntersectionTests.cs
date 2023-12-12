using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        var dict1 = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, int>();

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        var dict1 = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        var dict1 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
        var dict2 = new Dictionary<string, int> { { "c", 3 }, { "d", 4 } };

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        var dict1 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
        var dict2 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.AreEqual(dict1, result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        var dict1 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
        var dict2 = new Dictionary<string, int> { { "a", 3 }, { "b", 4 } };

        // Act
        var result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.IsEmpty(result);
    }
}
