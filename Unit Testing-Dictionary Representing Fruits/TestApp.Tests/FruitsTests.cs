using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>
            {
                {"Apple", 10},
                {"Banana", 5},
                {"Orange", 8}
            };
        var fruitName = "Banana";

        // Act
        var result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>
            {
                {"Apple", 10},
                {"Banana", 5},
                {"Orange", 8}
            };
        var fruitName = "Grapes";

        // Act
        var result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>();
        var fruitName = "Apple";

        // Act
        var result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = null;
        var fruitName = "Apple";

        // Act
        var result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>
            {
                {"Apple", 10},
                {"Banana", 5},
                {"Orange", 8}
            };
        string? fruitName = null;

        // Act
        var result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.AreEqual(0, result);
    }
}
