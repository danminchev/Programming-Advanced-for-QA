using NUnit.Framework;

using System;
using System.Numerics;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[0];

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "@--\\-" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 5 letters:{Environment.NewLine}@--\\-"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "@--\\-", "#-----", "narcissus", "fir" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 3 letters:{Environment.NewLine}fir{Environment.NewLine}" +
                                       $"Plants with 5 letters:{Environment.NewLine}@--\\-{Environment.NewLine}" +
                                       $"Plants with 6 letters:{Environment.NewLine}#-----{Environment.NewLine}" +
                                       $"Plants with 9 letters:{Environment.NewLine}narcissus"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "rOSe", "Narcissus", "TuLiP", "fiR" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 3 letters:{Environment.NewLine}fiR{Environment.NewLine}" +
                                       $"Plants with 4 letters:{Environment.NewLine}rOSe{Environment.NewLine}" +
                                       $"Plants with 5 letters:{Environment.NewLine}TuLiP{Environment.NewLine}" +
                                       $"Plants with 9 letters:{Environment.NewLine}Narcissus"));
    }
}
