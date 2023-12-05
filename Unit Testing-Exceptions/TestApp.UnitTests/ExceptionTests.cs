using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string? input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal totalPrice = 100;
        decimal discount = 20;
        decimal expectedDiscountedPrice = 80;

        // Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        // Assert
        Assert.That(result, Is.EqualTo(expectedDiscountedPrice));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = -10.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 2;
        int expectedElement = 30;

        // Act
        int result = _exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.That(result, Is.EqualTo(expectedElement));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => this._exceptions.IndexOutOfRangeGetElement(array, index));
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index),
            Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoggedIn = true;
        string expectedMessage = "User logged in.";

        // Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {// Arrange
        bool isLoggedIn = false;

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn));
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "123";
        int expectedParseValue = 123;

        // Act
        int result = this._exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedParseValue));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrance
        string invalidInput = "abc";

        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(invalidInput),
            Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            {"Key1", 10},
            {"Key2", 20},
            {"Key3", 30}
        };

        string existingKey = "Key2";
        int expectedValue = 20;

        // Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(dictionary, existingKey);

        // Assert
        Assert.That(result, Is.EqualTo(expectedValue));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            {"Key1", 10},
            {"Key2", 20},
            {"Key3", 30}
        };

        string nonExistingKey = "Key4";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, nonExistingKey));
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 10;
        int expectedSum = 15;

        // Act
        int result = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expectedSum));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
       // Arrange
        int a = int.MaxValue;
        int b = 1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => this._exceptions.OverflowAddNumbers(a, b));
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => this._exceptions.OverflowAddNumbers(a, b));
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int dividend = 10;
        int divisor = 5;
        int expectedQuotient = 2;

        // Act
        int result = this._exceptions.DivideByZeroDivideNumbers(dividend, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expectedQuotient));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 10;
        int divisor = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _exceptions.DivideByZeroDivideNumbers(dividend, divisor));
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = { 1, 2, 3, 4, 5 };
        int index = 4;
        int expectedSum = collection.Sum();

        // Act
        int result = this._exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.That(result, Is.EqualTo(expectedSum));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[]? collection = null;
        int index = 0;

        // Act & Assert 
        Assert.Throws<ArgumentNullException>(() => this._exceptions.SumCollectionElements(collection, index));
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = { 1, 2, 3, 4 };
        int index = 4;

        // Act & Assert 
        Assert.Throws<IndexOutOfRangeException>(() => this._exceptions.SumCollectionElements(collection, index));
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            {"Key1", "123"},
            {"Key2", "456"},
            {"Key3", "789"}
        };
        string validKey = "Key2";
        int expectedNumber = 456;

        // Act
        int result = this._exceptions.GetElementAsNumber(dictionary, validKey);

        // Assert
        Assert.That(result, Is.EqualTo(expectedNumber));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            {"Key1", "123"},
            {"Key2", "456"},
            {"Key3", "789"}
        };
        string key = "Key4";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => this._exceptions.GetElementAsNumber(dictionary, key));
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            {"Key1", "abc"}
        };
        string invalidFormatKey = "Key1";

        // Act & Assert
        Assert.Throws<FormatException>(() => this._exceptions.GetElementAsNumber(dictionary, invalidFormatKey));
    }
}
