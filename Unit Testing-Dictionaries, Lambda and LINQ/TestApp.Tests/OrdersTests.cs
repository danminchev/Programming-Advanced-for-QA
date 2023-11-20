using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange 
        string[] input = new string[0];

        // Act
        string result = Orders.Order(input);

        // Assert 
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange 
        string[] input = new string[]
        {
                "apple 2.00 1",
                "banana 1.00 1",
                "banana 2.00 2",
                "orange 1.00 2",
                "apple 2.50 2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 7.50{Environment.NewLine}banana -> 6.00{Environment.NewLine}orange -> 2.00"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange 
        string[] input = new string[]
        {
                "apple 2.000000001 1",
                "banana 1.00000002 1",
                "banana 2.000000003 2",
                "orange 1.00000004 2",
                "apple 2.00000002 2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 6.00{Environment.NewLine}banana -> 6.00{Environment.NewLine}orange -> 2.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange 
        string[] input = new string[]
        {
                "apple 4.50 2",
                "banana 2.50 3",
                "orange 3.50 1"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 9.00{Environment.NewLine}banana -> 7.50{Environment.NewLine}orange -> 3.50"));
    }
}

