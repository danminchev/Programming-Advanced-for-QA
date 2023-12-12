using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string productName = "TestProduct";
        double productPrice = 10.99;
        int productQuantity = 5;

        // Act
        _inventory.AddProduct(productName, productPrice, productQuantity);

        // Assert
        Assert.AreEqual(1, _inventory.DisplayInventory().Split('\n').Length - 1, "One product should be added to the inventory.");
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange & Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.AreEqual("Product Inventory:", result.Trim(), "Empty inventory should return 'Product Inventory:'.");
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("Product1", 19.99, 3);
        _inventory.AddProduct("Product2", 29.99, 2);

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        StringAssert.Contains("Product1", result, "Product1 should be in the inventory.");
        StringAssert.Contains("Product2", result, "Product2 should be in the inventory.");
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        /// Arrange & Act
        double totalValue = _inventory.CalculateTotalValue();

        // Assert
        Assert.AreEqual(0, totalValue, "Total value should be zero for an empty inventory.");
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        _inventory.AddProduct("Product1", 10.0, 2);
        _inventory.AddProduct("Product2", 5.0, 5);

        // Act
        double totalValue = _inventory.CalculateTotalValue();

        // Assert
        Assert.AreEqual(45.0, totalValue, "Total value should be calculated correctly for products in the inventory.");
    }
}
